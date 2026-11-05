namespace MyFinance;

public partial class Form1 : Form
{
    private readonly Color navy = Color.FromArgb(25, 35, 58);
    private readonly Color blue = Color.FromArgb(55, 105, 230);
    private readonly Color background = Color.FromArgb(246, 247, 251);
    private readonly Color muted = Color.FromArgb(125, 135, 153);

    public Form1()
    {
        InitializeComponent();

        Text = "MyFinance - Financial Reports";
        StartPosition = FormStartPosition.CenterScreen;
        ClientSize = new Size(1280, 800);
        MinimumSize = new Size(1000, 650);
        BackColor = background;
        Font = new Font("Segoe UI", 9F);

        BuildReportsPage();
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
