

using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Services
{
    public class MasProjectService : IMasProjectService
    {
        private readonly DataContext db;

        public MasProjectService(DataContext context)
        {
            this.db = context;
        }
        public ApiResponse GetAll(Query query)
        {
            ApiResponse response = new ApiResponse();
            List<ResponseModel> responseModels = new List<ResponseModel>();
            
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT mp.project_id as ProjectId, mp.project_code as ProjectCode, mp.project_name_th as ProjectNameTh, mp.project_name_en as ProjectNameEn, mu.unit_no as UnitNo, mu.house_no as HouseNo" +
            " FROM dbo.mas_project AS mp JOIN mas_unit mu ON mp.project_id = mu.mpj_project_id WHERE 1 = 1 ");

            if (query.TextSearch != null && query.TextSearch.Trim().Length > 0)
            {
                stringBuilder.AppendFormat("AND (mp.project_name_en LIKE '%{0}%' OR mp.project_name_th LIKE N'%{0}%') ", query.TextSearch);
            }

                var totalRecords = this.db.MasProject.FromSqlRaw(stringBuilder.ToString()).Count();
                if (totalRecords > 0)
                {
                //select เฉพาะ colum ที่ต้องการ ต้องระบู HasNoKey ใน Data Context MasProject=> FindMasProjectUnit
                var res = this.db.FindMasProjectUnit.FromSqlRaw(stringBuilder.ToString()).Skip(query.Skip * query.Limit).Take(query.Limit).ToList();
                    int rowNo = (query.Skip * query.Limit) + 1;
                    foreach (FindMasProjectUnit mp in res)
                    {
                        ResponseModel re = new ResponseModel();
                        re.RowNo = rowNo;
                        re.ProjectId = mp.ProjectId;
                        re.ProjectCode = mp.ProjectCode;
                        re.ProjectNameTh = mp.ProjectNameTh;
                        re.ProjectNameEn = mp.ProjectNameEn;
                        re.UnitNo = mp.UnitNo;
                        re.HouseNo= mp.HouseNo;
                        responseModels.Add(re);
                        rowNo++;
                    }
                    response.statusCode = "200";
                    response.currentPage = query.Skip;
                    response.pageSize = query.Limit;
                    response.totalRecords = totalRecords;
                    response.data = responseModels;
                }
            return response;
        }
    }
}
