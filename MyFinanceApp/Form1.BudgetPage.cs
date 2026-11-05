
namespace MyFinance;

public partial class Form1
{
    private void BuildBudgetPage(Panel host)
    {
        host.Controls.Clear();

        Panel content = new Panel
        {
            Dock = DockStyle.Fill,
            BackColor = background,
            Padding = new Padding(35, 28, 35, 25)
        };
        host.Controls.Add(content);

        Label title = new Label
        {
            Text = "Budget Planning",
            Font = new Font("Segoe UI", 23, FontStyle.Bold),
            ForeColor = Color.FromArgb(30, 40, 60),
            Location = new Point(35, 28),
            AutoSize = true
        };
        content.Controls.Add(title);

        Label subtitle = new Label
        {
            Text = "Plan your spending and keep your finances on track.",
            Font = new Font("Segoe UI", 10),
            ForeColor = muted,
            Location = new Point(38, 75),
            AutoSize = true
        };
        content.Controls.Add(subtitle);

        ComboBox monthSelector = new ComboBox
        {
            Location = new Point(750, 38),
            Size = new Size(145, 34),
            DropDownStyle = ComboBoxStyle.DropDownList,
            Font = new Font("Segoe UI", 9)
        };

        monthSelector.Items.AddRange(new object[]
        {
            "January 2026", "February 2026", "March 2026",
            "April 2026", "May 2026", "June 2026",
            "July 2026", "August 2026", "September 2026",
            "October 2026", "November 2026", "December 2026"
        });

        monthSelector.SelectedIndex = 10;
        content.Controls.Add(monthSelector);

        AddSummaryCard(content, "Monthly Budget", "$0.00", 35, 125);
        AddSummaryCard(content, "Spent So Far", "$0.00", 335, 125);
        AddSummaryCard(content, "Remaining", "$0.00", 635, 125);

        Label sectionTitle = new Label
        {
            Text = "Monthly Category Budgets",
            Font = new Font("Segoe UI", 15, FontStyle.Bold),
            ForeColor = Color.FromArgb(35, 45, 65),
            Location = new Point(35, 300),
            AutoSize = true
        };
        content.Controls.Add(sectionTitle);

        Button newBudgetButton = new Button
        {
            Text = "+  New Budget",
            Location = new Point(740, 292),
            Size = new Size(155, 40),
            BackColor = blue,
            ForeColor = Color.White,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Segoe UI", 9, FontStyle.Bold),
            Cursor = Cursors.Hand
        };

        newBudgetButton.FlatAppearance.BorderSize = 0;

        newBudgetButton.Click += (_, _) =>
        {
            MessageBox.Show(
                "The new budget form will be implemented next.",
                "New Budget",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        };

        content.Controls.Add(newBudgetButton);

        Panel emptyPanel = new Panel
        {
            Location = new Point(35, 350),
            Size = new Size(860, 340),
            BackColor = Color.White
        };
        content.Controls.Add(emptyPanel);

        Label emptyTitle = new Label
        {
            Text = "No budgets created yet",
            Font = new Font("Segoe UI", 15, FontStyle.Bold),
            ForeColor = Color.FromArgb(45, 55, 75),
            AutoSize = true
        };

        emptyTitle.Location = new Point(
            (emptyPanel.Width - emptyTitle.PreferredWidth) / 2, 125);

        emptyPanel.Controls.Add(emptyTitle);

        Label emptyDescription = new Label
        {
            Text = "Create a budget to start tracking category limits.",
            Font = new Font("Segoe UI", 10),
            ForeColor = muted,
            AutoSize = true
        };

        emptyDescription.Location = new Point(
            (emptyPanel.Width - emptyDescription.PreferredWidth) / 2, 165);

        emptyPanel.Controls.Add(emptyDescription);
    }
}
