namespace SplitWiseWebApp.Data
{
    public class ExpenseService
    {
        private readonly SqlConnectionConfiguration _connectionConfiguration;
        public ExpenseService(SqlConnectionConfiguration connectionConfiguration)
        {
            _connectionConfiguration = connectionConfiguration; 
        }


    }
}
