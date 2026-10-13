namespace Task1ExpenseTracker;

public sealed class Expense
{
    public string Description { get; }
    public decimal Amount { get; }

    public Expense(string description, decimal amount)
    {
        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException("Description cannot be empty.", nameof(description));
        }

        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                "Amount must be greater than zero.");
        }

        Description = description.Trim();
        Amount = amount;
    }
}
