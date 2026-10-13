# Task 1 — Expense Tracker Console App

A small .NET console application that models expenses and an expense report using C# classes.

## Requirements covered

- **Two model classes:** `Expense` and `ExpenseReport`.
- **Properties, not public fields:** model data is exposed through C# properties.
- **Constructor validation:** `Expense` rejects a blank description and amounts less than or equal to zero. `ExpenseReport` rejects a blank title.
- **Readable console output:** the app prints a report summary, total and individual expenses.
- **Builds and runs:** targets .NET 8.

## Requirements

Install the .NET 8 SDK: https://dotnet.microsoft.com/download/dotnet/8.0

Check the installation:

```bash
dotnet --version
```

## Run the project

From the directory containing `Task1ExpenseTracker.csproj`:

```bash
dotnet restore
dotnet run
```

Build without running:

```bash
dotnet build
```

## Example output

Currency formatting depends on your computer's regional settings. Example:

```text
Weekly expenses
Number of expenses: 3
Total: $64.25

Expense details:
- Groceries: $42.50
- Bus pass: $15.00
- Notebook: $6.75
```

## Design decisions

- `Expense` represents one expense. Its constructor validates the description and amount before assigning them.
- `ExpenseReport` stores expenses in a private list and exposes a read-only view so callers cannot add items by modifying a public list.
- `decimal` is used for money because it is generally more suitable for decimal monetary values than `float` or `double`.
- The sample data is kept in `Program.cs` to keep the project small and easy to review.

## Possible improvement

A future version could let users enter expenses interactively. That extra feature is intentionally omitted because the task asks for a small, finished console application.

## Repository contents

- `Program.cs` — application entry point and sample usage.
- `Expense.cs` — validated expense model.
- `ExpenseReport.cs` — collection, total and summary logic.
- `Task1ExpenseTracker.csproj` — .NET project configuration.
