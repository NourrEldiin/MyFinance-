# MyFinance — Personal Finance Management System

**Course:** CS.312 — Modern Development
**Project Type:** C# Windows Forms Application

## Overview

MyFinance is a desktop personal finance management application developed as a university team project. It provides a graphical interface for organizing and reviewing personal financial information through dedicated sections for income, expenses, budget planning, and financial reports.

The project currently focuses on the application's user interface, navigation, and visual presentation. It is a UI prototype rather than a fully functional financial management system.

## Application Features

- **Login and Registration:** User-facing login and registration screens.
- **Dashboard:** Financial overview with summary cards, income and expense sections, and recent transaction placeholders.
- **Income Management:** Interface for viewing and organizing income entries.
- **Expense Management:** Interface for viewing and organizing expenses.
- **Budget Planning:** Budget overview and category-based budget interface.
- **Financial Reports:** Reporting interface with a reporting-period selector and report panels.

## Technology Stack

- **Language:** C#
- **Framework:** .NET 10
- **Desktop UI:** Windows Forms (WinForms)
- **IDE:** Visual Studio
- **Solution Format:** Visual Studio `.slnx`

## Project Structure

```text
MyFinance/
├── MyFinance.slnx
├── README.md
└── MyFinanceApp/
    ├── MyFinance.csproj
    ├── Program.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.DashboardPage.cs
    ├── Form1.BudgetPage.cs
    ├── Form1.ReportsPage.cs
    ├── IncomeForm.cs
    ├── Expenses.cs
    ├── RoundedPanel.cs
    └── Login/
        ├── frmLogin.cs
        └── frmRegister.cs
```

The project also contains the associated Windows Forms Designer files and resources.

## Requirements

- Windows operating system.
- .NET 10 SDK.
- Visual Studio with the **.NET desktop development** workload, or another environment capable of building .NET 10 Windows Forms applications.

## Getting Started

### Open in Visual Studio

1. Clone or download the repository.
2. Open `MyFinance.slnx` in Visual Studio.
3. Allow the project to restore its dependencies.
4. Set `MyFinanceApp` as the startup project if necessary.
5. Build and run the application.

### Build from the .NET CLI

From the repository root:

```bash
dotnet restore MyFinance.slnx
dotnet build MyFinance.slnx
```

To run the application on Windows:

```bash
dotnet run --project MyFinanceApp/MyFinance.csproj
```

The project targets Windows Forms, so building it with Windows targeting enabled on Linux does not make the desktop application runnable natively on Linux.

## Current Scope and Limitations

The current release focuses on the user interface and navigation.

- No database integration or persistent financial records.
- No functional authentication or credential validation.
- Financial summary values and transaction sections use placeholders.
- Budget and report interfaces are presentation-focused.
- No actual financial calculations or report generation are connected to a backend.

These limitations reflect the current UI-focused project scope and leave room for future development.

## Team Contributions

The application is developed collaboratively as part of CS.312.

**Individual contribution:** Budget Planning and Financial Reports user interfaces, including their layouts and visual components.

Other application sections were developed and integrated as part of the team's work.

---

*MyFinance — CS.312 Modern Development Project.*
