namespace SplitWiseWebApp.Data
{
    public class Expense
    {
        public int ExpenseID { get; set; }

        public string? ExpenseName { get; set;}

        public decimal Amount { get; set; }

        public int GroupID { get; set; }

        public DateTime? CreatedAT { get; set; }=DateTime.Now;


    }
}
