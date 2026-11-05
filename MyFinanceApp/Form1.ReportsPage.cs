namespace MyFinance;

public partial class Form1
{
    private void BuildReportsPage()
    {
        Controls.Clear();

        // Sidebar
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

        string[] menuItems =
        {
            "Dashboard",
            "Income",
            "Expenses",
            "Budget Planning",
            "Financial Reports"
        };

        for (int i = 0; i < menuItems.Length; i++)
        {
            string menuItem = menuItems[i];
            bool active = menuItem == "Financial Reports";

            Button menuButton = new Button
            {
                Text = "   " + menuItem,
                Location = new Point(12, 140 + i * 52),
                Size = new Size(211, 43),
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 10,
                    active ? FontStyle.Bold : FontStyle.Regular),
                ForeColor = active ? Color.White :
                    Color.FromArgb(195, 202, 216),
                BackColor = active ? blue : navy,
                Cursor = Cursors.Hand
            };

            menuButton.FlatAppearance.BorderSize = 0;
            sidebar.Controls.Add(menuButton);
        }

        // Main content
        Panel content = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = background,
            Padding = new Padding(35, 28, 35, 25)
        };

        Controls.Add(content);
        content.BringToFront();

        // Page heading
        Label title = new Label
        {
            Text = "Financial Reports",
            Font = new Font("Segoe UI", 23, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 40, 60),
            Location = new Point(35, 28),
            AutoSize = true
        };
        content.Controls.Add(title);

        Label subtitle = new Label
        {
            Text = "Track your financial performance and spending habits.",
            Font = new Font("Segoe UI", 10),
            ForeColor = muted,
            Location = new Point(38, 75),
            AutoSize = true
        };
        content.Controls.Add(subtitle);

        // Summary cards
        AddSummaryCard(content, "Total Income", "$0.00", 35, 125);
        AddSummaryCard(content, "Total Expenses", "$0.00", 335, 125);
        AddSummaryCard(content, "Savings Rate", "0%", 635, 125);

        // Chart section titles
        Label incomeTitle = new Label
        {
            Text = "Income & Expenses Summary",
            Font = new Font("Segoe UI", 13, FontStyle.Bold),
            ForeColor = Color.FromArgb(35, 45, 65),
            Location = new Point(35, 295),
            AutoSize = true
        };
        content.Controls.Add(incomeTitle);

        Label expenseTitle = new Label
        {
            Text = "Expense Breakdown",
            Font = new Font("Segoe UI", 13, FontStyle.Bold),
            ForeColor = Color.FromArgb(35, 45, 65),
            Location = new Point(475, 295),
            AutoSize = true
        };
        content.Controls.Add(expenseTitle);

        // Chart panels
        Panel incomePanel = CreateChartPanel(
            35, 330, 420,
            "Not enough data to show a report",
            "Add transactions to generate a summary."
        );
        content.Controls.Add(incomePanel);

        Panel expensePanel = CreateChartPanel(
            475, 330, 420,
            "No expense data yet",
            "Add expenses to see your breakdown."
        );
        content.Controls.Add(expensePanel);

        // Report period selector
        ComboBox periodSelector = new ComboBox
        {
            Location = new Point(35, 625),
            Size = new Size(160, 34),
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9)
        };

        periodSelector.Items.AddRange(new object[]
        {
            "Last 6 Months",
            "Last 3 Months",
            "Last 12 Months"
        });

        periodSelector.SelectedIndex = 0;
        content.Controls.Add(periodSelector);

        // Export button
        Button exportButton = new Button
        {
            Text = "Export Report",
            Location = new Point(740, 620),
            Size = new Size(155, 40),
            BackColor = blue,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            Cursor = Cursors.Hand
        };

        exportButton.FlatAppearance.BorderSize = 0;

        exportButton.Click += (_, _) =>
        {
            MessageBox.Show(
                "Report export will be implemented next.",
                "Export Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        };

        content.Controls.Add(exportButton);
    }

    private Panel CreateChartPanel(
        int x, int y, int width,
        string heading, string description)
    {
        Panel panel = new Panel
        {
            Location = new Point(x, y),
            Size = new Size(width, 260),
            BackColor = Color.White
        };

        Label headingLabel = new Label
        {
            Text = heading,
            Font = new Font("Segoe UI", 12, FontStyle.Bold),
            ForeColor = Color.FromArgb(45, 55, 75),
            AutoSize = true
        };

        Label descriptionLabel = new Label
        {
            Text = description,
            Font = new Font("Segoe UI", 9),
            ForeColor = muted,
            AutoSize = true
        };

        headingLabel.Location = new Point(
            (width - headingLabel.PreferredWidth) / 2, 100);

        descriptionLabel.Location = new Point(
            (width - descriptionLabel.PreferredWidth) / 2, 140);

        panel.Controls.Add(headingLabel);
        panel.Controls.Add(descriptionLabel);

        return panel;
    }
}
