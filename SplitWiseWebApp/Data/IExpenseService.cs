namespace SplitWiseWebApp.Data
{
    public interface IExpenseService
    {
        Task<bool> ExpenseInsert(Expense expense);
        Task<IEnumerable<Expense>> GetExpenses();
    }
}