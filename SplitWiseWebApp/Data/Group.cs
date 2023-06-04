namespace SplitWiseWebApp.Data
{
    public class Group
    {
        public int GroupID { get; set; }
        public string? UserID { get; set; }
        public string? Name { get; set; } 

        public DateTime CreatedAT { get; set; }= DateTime.Now;
    }
}
