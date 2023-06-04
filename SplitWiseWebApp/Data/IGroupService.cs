namespace SplitWiseWebApp.Data
{
    public interface IGroupService
    {
        Task<IEnumerable<Group>> GetGroups();
        Task<bool> GroupInsert(GroupMember groupMember);
    }
}