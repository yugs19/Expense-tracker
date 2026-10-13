using Task1ExpenseTracker;

var report = new ExpenseReport("Weekly expenses");

report.AddExpense(new Expense("Groceries", 42.50m));
report.AddExpense(new Expense("Bus pass", 15.00m));
report.AddExpense(new Expense("Notebook", 6.75m));

Console.WriteLine(report.GetSummary());

Console.WriteLine();
Console.WriteLine("Expense details:");
foreach (Expense expense in report.Expenses)
{
    Console.WriteLine($"- {expense.Description}: {expense.Amount:C}");
}
