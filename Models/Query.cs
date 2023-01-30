namespace DemoProject.Models
{
    public class Query
    {
        public int Skip { get; set; }
        public int Limit { get; set; }

        public string TextSearch { get; set; }
    }
}
