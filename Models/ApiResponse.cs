using Microsoft.AspNetCore.Http;

namespace DemoProject.Models
{
    public class ApiResponse
    {
        public string statusCode { get; set; }
        public string error { get; set; } = "";
        public string message { get; set; }
        public dynamic data { get; set; }


    }
}
