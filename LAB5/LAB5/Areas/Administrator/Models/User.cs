namespace LAB5.Areas.Administrator.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public int progress { get; set; }
        public double amount { get; set; }
        public DateTime deadline { get; set; }
        public string image { get; set; }
    }
}   