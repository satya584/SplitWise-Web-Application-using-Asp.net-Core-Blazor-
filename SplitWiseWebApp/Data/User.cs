namespace SplitWiseWebApp.Data
{
    public class User
    {
        public int userId { get; set; }
        public string? name { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
     
        public DateTime createdAt { get; set; }= DateTime.Now;
        public DateTime UpdatedAt { get; set; } =DateTime.Now;


    }
}
