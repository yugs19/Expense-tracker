namespace Task1ExpenseTracker;

public sealed class ExpenseReport
{
    private readonly List<Expense> _expenses = new();

    public string Title { get; }
    public IReadOnlyList<Expense> Expenses => _expenses.AsReadOnly();
    public decimal Total => _expenses.Sum(expense => expense.Amount);

    public ExpenseReport(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
        {
            throw new ArgumentException("Report title cannot be empty.", nameof(title));
        }

        Title = title.Trim();
    }

    public void AddExpense(Expense expense)
    {
        ArgumentNullException.ThrowIfNull(expense);
        _expenses.Add(expense);
    }

    public string GetSummary()
    {
        return $"{Title}\n" +
               $"Number of expenses: {_expenses.Count}\n" +
               $"Total: {Total:C}";
    }
}
