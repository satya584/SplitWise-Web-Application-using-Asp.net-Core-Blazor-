using Dapper;
using System.Data;

namespace SplitWiseWebApp.Data
{
    public class ExpenseService : IExpenseService
    {
        private readonly SqlConnectionConfiguration _connectionConfiguration;
        public ExpenseService(SqlConnectionConfiguration connectionConfiguration)
        {
            _connectionConfiguration = connectionConfiguration;
        }

        public async Task<IEnumerable<Expense>> GetExpenses()
        {
            var query = "SELECT ExpenseName, Amount, CreatedBY FROM  ExpensesTable";
            using (var connection = _connectionConfiguration.CreateConnection())
            {
                var expenses = await connection.QueryAsync<Expense>(query);
                return expenses.ToList();
            }
        }

        public async Task<bool> ExpenseInsert(Expense expense)
        {
            using (var connection = _connectionConfiguration.CreateConnection())
            {
                var parameters = new DynamicParameters();
                parameters.Add("ExpenseName", expense.ExpenseName, DbType.String);
                parameters.Add("Amount", expense.Amount, DbType.Decimal);


                var query = "INSERT INTO ExpensesTable (ExpenseName, Amount)  VALUES (@ExpenseName, @Amount)";
                await connection.ExecuteAsync(query, new { expense.ExpenseName, expense.Amount }, commandType: CommandType.Text);

            }
            return true;
        }
    }
}
 