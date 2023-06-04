using Dapper;
using Microsoft.Data.SqlClient;

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



    }
}
