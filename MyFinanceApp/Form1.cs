namespace MyFinance;

public partial class Form1 : Form
{
    private readonly Color navy = Color.FromArgb(25, 35, 58);
    private readonly Color blue = Color.FromArgb(55, 105, 230);
    private readonly Color background = Color.FromArgb(246, 247, 251);
    private readonly Color muted = Color.FromArgb(125, 135, 153);

    private readonly Panel contentHost = new Panel();

    private IncomeForm? incomePage;
    private ExpensesForm? expensesPage;

    private Button dashboardButton = null!;
    private Button reportsButton = null!;
    private Button incomeButton = null!;
    private Button expensesButton = null!;
    private Button budgetButton = null!;

    public Form1()
    {
        InitializeComponent();

        Text = "MyFinance";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(1280, 800);
        MinimumSize = new Size(1000, 650);
        BackColor = background;
        Font = new Font("Segoe UI", 9F);

        BuildMainLayout();
        ShowDashboardPage();
    }

    private void BuildMainLayout()
    {
        Panel sidebar = new Panel
        {
            Dock = DockStyle.Left,
            Width = 235,
            BackColor = navy
        };

        Controls.Add(sidebar);

        Label logo = new Label
        {
            Text = "MyFinance",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 19, FontStyle.Bold),
            Location = new Point(25, 28),
            AutoSize = true
        };

        sidebar.Controls.Add(logo);

        Label menuHeading = new Label
        {
            Text = "MAIN MENU",
            ForeColor = Color.FromArgb(150, 160, 180),
            Font = new Font("Segoe UI", 8, FontStyle.Bold),
            Location = new Point(25, 105),
            AutoSize = true
        };

        sidebar.Controls.Add(menuHeading);

        dashboardButton = CreateNavigationButton("Dashboard", 140);
        incomeButton = CreateNavigationButton("Income", 192);
        expensesButton = CreateNavigationButton("Expenses", 244);
        budgetButton = CreateNavigationButton("Budget", 296);
        reportsButton = CreateNavigationButton("Reports", 348);

        dashboardButton.Click += (_, _) => ShowDashboardPage();
        incomeButton.Click += (_, _) => ShowIncomePage();
        expensesButton.Click += (_, _) => ShowExpensesPage();
        budgetButton.Click += (_, _) => ShowBudgetPage();
        reportsButton.Click += (_, _) => ShowReportsPage();

        sidebar.Controls.Add(dashboardButton);
        sidebar.Controls.Add(incomeButton);
        sidebar.Controls.Add(expensesButton);
        sidebar.Controls.Add(budgetButton);
        sidebar.Controls.Add(reportsButton);

        contentHost.Dock = DockStyle.Fill;
        contentHost.BackColor = background;

        Controls.Add(contentHost);
        contentHost.BringToFront();
    }

    private Button CreateNavigationButton(string text, int y)
    {
        Button button = new Button
        {
            Text = "   " + text,
            Location = new Point(12, y),
            Size = new Size(211, 43),
            FlatStyle = FlatStyle.Flat,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = new Font("Segoe UI", 10),
            ForeColor = Color.FromArgb(195, 202, 216),
            BackColor = navy,
            Cursor = Cursors.Hand
        };

        button.FlatAppearance.BorderSize = 0;

        return button;
    }

    private void SetActiveButton(Button activeButton)
    {
        foreach (Button button in new[]
        {
            dashboardButton,
            incomeButton,
            expensesButton,
            budgetButton,
            reportsButton
        })
        {
            button.BackColor = navy;
            button.ForeColor = Color.FromArgb(195, 202, 216);
            button.Font = new Font("Segoe UI", 10);
        }

        activeButton.BackColor = blue;
        activeButton.ForeColor = Color.White;
        activeButton.Font = new Font("Segoe UI", 10, FontStyle.Bold);
    }

    private void ShowDashboardPage()
    {
        SetActiveButton(dashboardButton);
        BuildDashboardPage(contentHost);
    }

    private void ShowReportsPage()
    {
        SetActiveButton(reportsButton);
        BuildReportsPage(contentHost);
    }

    private void ShowBudgetPage()
    {
        SetActiveButton(budgetButton);
        BuildBudgetPage(contentHost);
    }

    private void ShowIncomePage()
    {
        SetActiveButton(incomeButton);

        incomePage ??= new IncomeForm();

        contentHost.Controls.Clear();
        contentHost.Controls.Add(incomePage.GetPageContent());
    }

    private void ShowExpensesPage()
    {
        SetActiveButton(expensesButton);

        expensesPage ??= new ExpensesForm();

        contentHost.Controls.Clear();
        contentHost.Controls.Add(expensesPage.GetPageContent());
    }

    private void AddSummaryCard(
        Control parent, string heading, string amount, int x, int y)
    {
        Panel card = new Panel
        {
            Location = new Point(x, y),
            Size = new Size(275, 135),
            BackColor = Color.White
        };

        parent.Controls.Add(card);

        Label headingLabel = new Label
        {
            Text = heading,
            Location = new Point(20, 20),
            AutoSize = true,
            Font = new Font("Segoe UI", 10),
            ForeColor = muted
        };

        card.Controls.Add(headingLabel);

        Label amountLabel = new Label
        {
            Text = amount,
            Location = new Point(20, 55),
            AutoSize = true,
            Font = new Font("Segoe UI", 22, FontStyle.Bold),
            ForeColor = Color.FromArgb(35, 45, 65)
        };

        card.Controls.Add(amountLabel);
    }
}
