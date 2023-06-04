using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;

namespace SplitWiseWebApp.Data
{
    public class GroupService : IGroupService
    {
        private readonly SqlConnectionConfiguration _connectionConfiguration;
        public GroupService(SqlConnectionConfiguration connectionConfiguration)
        {

            _connectionConfiguration = connectionConfiguration;

        }

        public async Task<IEnumerable<Group>> GetGroups()
        {

            var query = "SELECT GroupID, UserID, Name FROM GroupTable";

            using (var connection = _connectionConfiguration.CreateConnection())
            {
                var groups = await connection.QueryAsync<Group>(query);
                return groups.ToList();
            }

        }

        public async Task<bool> GroupInsert(GroupMember groupMember)
        {
            using(var connection = _connectionConfiguration.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("GroupMembers", groupMember.GroupMembers, DbType.String);

                var query = "INSERT INTO GroupMemberTable (GroupMembers) VALUES (@GroupMembers)";
                await connection.ExecuteAsync(query, new {groupMember.GroupMembers }, commandType:CommandType.Text);

            }
            return true;
        }

    }
}
