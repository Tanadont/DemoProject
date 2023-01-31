

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
            stringBuilder.Append("SELECT * FROM dbo.mas_project AS mp WHERE 1 = 1 ");

            if (query.TextSearch != null && query.TextSearch.Trim().Length > 0)
            {
                stringBuilder.AppendFormat("AND (mp.project_name_en LIKE '%{0}%' OR mp.project_name_th LIKE N'%{0}%') ", query.TextSearch);
            }

                var totalRecords = this.db.MasProject.FromSqlRaw(stringBuilder.ToString()).Count();
                if (totalRecords > 0)
                {
                    var res = this.db.MasProject.FromSqlRaw(stringBuilder.ToString()).Skip(query.Skip * query.Limit).Take(query.Limit).ToList();
                    int rowNo = (query.Skip * query.Limit) + 1;
                    foreach (MasProjectModel mp in res)
                    {
                        ResponseModel re = new ResponseModel();
                        re.RowNo = rowNo;
                        re.ProjectId = mp.ProjectId;
                        re.ProjectCode = mp.ProjectCode;
                        re.ProjectNameTh = mp.ProjectNameTh;
                        re.ProjectNameEn = mp.ProjectNameEn;
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
