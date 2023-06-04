namespace SplitWiseWebApp.Data
{
    public class GroupMember
    {
        public int GroupID { get; set; }

        public string? GroupMembers { get; set; }

        public DateTime CreatedAT { get; set; }=DateTime.Now;
    }
}
