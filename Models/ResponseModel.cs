namespace DemoProject.Models
{
    public class ResponseModel
    {
        public int RowNo { get; set; }
        public int ProjectId { get; set; } = 1;
        public string ProjectCode { get; set; } = "";
        public string ProjectNameTh { get; set; } = "";
        public string ProjectNameEn { get; set; } = "";
        public string UnitNo { get; set; } = "";
        public string HouseNo { get; set; } = "";
    }
}
