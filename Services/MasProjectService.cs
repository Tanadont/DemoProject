

using System.Collections.Generic;
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
        public ApiResponse GetAll(int limit)
        {
            ApiResponse response = new ApiResponse();
            List<ResponseModel> responseModels = new List<ResponseModel>();
            var res = this.db.MasProject.FromSql($"SELECT * FROM dbo.mas_project").Take(limit).ToList();
            foreach(MasProjectModel mp in res){
                ResponseModel re = new ResponseModel();
                re.ProjectId = mp.ProjectId;
                re.ProjectCode = mp.ProjectCode;
                re.ProjectNameTh = mp.ProjectNameTh;
                re.ProjectNameEn = mp.ProjectNameEn;
                responseModels.Add(re);
            }
            response.statusCode = "200";
            response.data = responseModels;
            return response;
        }
    }
}
