using Microsoft.Data.SqlClient;
using System.Data;

namespace SplitWiseWebApp.Data
{
    public class SqlConnectionConfiguration
    {
        private readonly IConfiguration? _configuration;

        private readonly string? _connectionString;

        public SqlConnectionConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlDBcontext");
            
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString); 
    }
}
