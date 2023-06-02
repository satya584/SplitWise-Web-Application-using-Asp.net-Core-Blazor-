using Dapper;
using Microsoft.Data.SqlClient;

namespace SplitWiseWebApp.Data
{
    public class UserService
    {
        private readonly SqlConnectionConfiguration _connectionConfiguration;
        public UserService(SqlConnectionConfiguration connectionConfiguration)
        {

            _connectionConfiguration = connectionConfiguration;

        }

        

    }
}
