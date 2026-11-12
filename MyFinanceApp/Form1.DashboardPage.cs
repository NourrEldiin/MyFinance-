namespace MyFinance;

public partial class Form1
{
    private static readonly Color DashboardInk = ColorTranslator.FromHtml("#1B2340");
    private static readonly Color DashboardMuted = ColorTranslator.FromHtml("#7C88A8");
    private static readonly Color DashboardMid = ColorTranslator.FromHtml("#5B6685");
    private static readonly Color DashboardBorder = ColorTranslator.FromHtml("#E5E9F2");
    private static readonly Color DashboardIconBg = ColorTranslator.FromHtml("#EEF4FF");
    private static readonly Color DashboardPlaceholder = ColorTranslator.FromHtml("#B8C0D8");
    private static readonly Color DashboardRing = ColorTranslator.FromHtml("#DCE2F0");
    private static readonly Color DashboardPlusGray = ColorTranslator.FromHtml("#C5CCE0");
    private static readonly Color DashboardHeaderBg = ColorTranslator.FromHtml("#F7F9FC");

    private Label dashboardIncomeValue = null!;
    private Label dashboardExpensesValue = null!;
    private Label dashboardBalanceValue = null!;
    private ComboBox dashboardMonthSelector = null!;

    private void BuildDashboardPage(Panel host)
    {
        host.Controls.Clear();

        var main = new RoundedPanel
        {
            Dock = DockStyle.Fill,
            Margin = Padding.Empty,
            Padding = new Padding(24),
            CornerRadius = 20,
            Corners = RoundedCorners.TopRight | RoundedCorners.BottomRight,
            FillColor = Color.White
        };

        host.Controls.Add(main);
        BuildDashboardContent(main);
    }

        private void BuildDashboardContent(RoundedPanel main)
        {
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                BackColor = Color.White
            };
            layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 64));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 210));
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            main.Controls.Add(layout);

            layout.Controls.Add(BuildDashboardHeader(), 0, 0);
            layout.Controls.Add(BuildDashboardStatCards(), 0, 1);
            layout.Controls.Add(BuildDashboardChartCards(), 0, 2);
            layout.Controls.Add(BuildDashboardRecentTransactions(), 0, 3);
        }

        private Control BuildDashboardHeader()
        {
            var header = new Panel { Dock = DockStyle.Fill, Margin = Padding.Empty, BackColor = Color.White };

            var title = MakeDashboardLabel("Dashboard", 18f, FontStyle.Bold, DashboardInk);
            title.Location = new Point(0, 0);
            var subtitle = MakeDashboardLabel("Your financial overview at a glance", 8.5f, FontStyle.Regular, DashboardMuted);
            subtitle.Location = new Point(2, 36);

            dashboardMonthSelector = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 190,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = DashboardMid,
                Font = new Font("Segoe UI", 8.5f),
                Top = 2
            };
            for (int i = 0; i < 12; i++)
                dashboardMonthSelector.Items.Add(DateTime.Today.AddMonths(-i).ToString("MMMM yyyy"));
            dashboardMonthSelector.SelectedIndex = 0;

            header.Controls.AddRange(new Control[] { title, subtitle, dashboardMonthSelector });
            header.Resize += (s, e) => dashboardMonthSelector.Left = header.Width - dashboardMonthSelector.Width;
            dashboardMonthSelector.Left = header.Width - dashboardMonthSelector.Width;
            return header;
        }

        private Control BuildDashboardStatCards()
        {
            var row = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                ColumnCount = 3,
                RowCount = 1,
                BackColor = Color.White
            };
            for (int i = 0; i < 3; i++)
                row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33f));
            row.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            row.Controls.Add(CreateDashboardStatCard("Total Income", ColorTranslator.FromHtml("#3B82F6"),
                new Padding(0, 0, 8, 16), out dashboardIncomeValue), 0, 0);
            row.Controls.Add(CreateDashboardStatCard("Total Expenses", ColorTranslator.FromHtml("#EF4466"),
                new Padding(8, 0, 8, 16), out dashboardExpensesValue), 1, 0);
            row.Controls.Add(CreateDashboardStatCard("Remaining Balance", ColorTranslator.FromHtml("#14B8A6"),
                new Padding(8, 0, 0, 16), out dashboardBalanceValue), 2, 0);
            return row;
        }

        private RoundedPanel CreateDashboardStatCard(string title, Color dotColor, Padding margin, out Label valueLabel)
        {
            var card = NewDashboardCard(margin);

            var t = MakeDashboardLabel(title, 8.5f, FontStyle.Regular, DashboardMuted);
            t.Location = new Point(16, 14);

            valueLabel = MakeDashboardLabel("—", 16f, FontStyle.Bold, DashboardPlaceholder);
            valueLabel.Location = new Point(16, 40);

            var icon = new RoundedPanel
            {
                Size = new Size(28, 28),
                Top = 12,
                CornerRadius = 8,
                FillColor = DashboardIconBg
            };
            icon.Controls.Add(new RoundedPanel
            {
                Size = new Size(6, 6),
                Location = new Point(11, 11),
                CornerRadius = 3,
                FillColor = dotColor
            });

            card.Controls.AddRange(new Control[] { t, valueLabel, icon });
            PinDashboardRight(card, icon, 14);
            return card;
        }

        private Control BuildDashboardChartCards()
        {
            var row = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                ColumnCount = 2,
                RowCount = 1,
                BackColor = Color.White
            };
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
            row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));
            row.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var left = NewDashboardCard(new Padding(0, 0, 8, 16));
            var lt = MakeDashboardLabel("Income vs. Expenses", 9f, FontStyle.Bold, DashboardInk);
            lt.Location = new Point(16, 14);
            left.Controls.Add(lt);
            BuildDashboardEmptyState(left, "No transactions yet",
                "Add income and expenses to see your trends.", 44, 36);

            var right = NewDashboardCard(new Padding(8, 0, 0, 16));
            var rt = MakeDashboardLabel("Expenses by Category", 9f, FontStyle.Bold, DashboardInk);
            rt.Location = new Point(16, 14);
            right.Controls.Add(rt);
            BuildDashboardEmptyState(right, "No expense data yet",
                "Your data will appear here when you add it.", 44, 36);

            row.Controls.Add(left, 0, 0);
            row.Controls.Add(right, 1, 0);
            return row;
        }

        private Control BuildDashboardRecentTransactions()
        {
            var card = NewDashboardCard(Padding.Empty);

            var title = MakeDashboardLabel("Recent Transactions", 9f, FontStyle.Bold, DashboardInk);
            title.Location = new Point(16, 14);
            card.Controls.Add(title);

            // Table header
            var strip = new TableLayoutPanel
            {
                Location = new Point(16, 44),
                Height = 30,
                ColumnCount = 5,
                RowCount = 1,
                BackColor = DashboardHeaderBg
            };
            float[] widths = { 28, 20, 20, 16, 16 };
            string[] heads = { "Description", "Category", "Date", "Type", "Amount" };
            for (int i = 0; i < 5; i++)
            {
                strip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, widths[i]));
                strip.Controls.Add(new Label
                {
                    Text = heads[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Padding = new Padding(10, 0, 0, 0),
                    Font = new Font("Segoe UI", 7.5f, FontStyle.Bold),
                    ForeColor = DashboardMuted
                }, i, 0);
            }
            strip.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var rule = new Panel { Location = new Point(16, 74), Height = 1, BackColor = DashboardBorder };

            card.Controls.Add(strip);
            card.Controls.Add(rule);

            void LayoutTable()
            {
                strip.Width = Math.Max(0, card.Width - 32);
                rule.Width = strip.Width;
            }
            card.Resize += (s, e) => LayoutTable();
            LayoutTable();

            BuildDashboardEmptyState(card, "No transactions yet",
                "Your recent activity will appear here.", 36, 76);
            return card;
        }


        private static RoundedPanel NewDashboardCard(Padding margin)
        {
            return new RoundedPanel
            {
                Dock = DockStyle.Fill,
                Margin = margin,
                CornerRadius = 12,
                FillColor = Color.White,
                BorderColor = DashboardBorder
            };
        }

        private static Label MakeDashboardLabel(string text, float size, FontStyle style, Color color)
        {
            return new Label
            {
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = color,
                Font = new Font("Segoe UI", size, style),
                Text = text
            };
        }

        private static void PinDashboardRight(Control parent, Control child, int margin)
        {
            void Place() => child.Left = parent.Width - child.Width - margin;
            parent.Resize += (s, e) => Place();
            Place();
        }


        private static void BuildDashboardEmptyState(RoundedPanel card, string title, string subtitle,
                                            int circleSize, int topOffset)
        {
            var circle = new RoundedPanel
            {
                Size = new Size(circleSize, circleSize),
                CornerRadius = circleSize / 2,
                FillColor = Color.White,
                BorderColor = DashboardRing
            };
            var plus = MakeDashboardLabel("+", circleSize > 40 ? 18f : 14f, FontStyle.Regular, DashboardPlusGray);
            plus.AutoSize = false;
            plus.Dock = DockStyle.Fill;
            plus.TextAlign = ContentAlignment.MiddleCenter;
            circle.Controls.Add(plus);

            var t = MakeDashboardLabel(title, 8.5f, FontStyle.Bold, DashboardMid);
            var s = MakeDashboardLabel(subtitle, 7.5f, FontStyle.Regular, DashboardMuted);

            card.Controls.AddRange(new Control[] { circle, t, s });

            void DoLayout()
            {
                int block = circle.Height + 8 + t.Height + 2 + s.Height;
                int top = topOffset + Math.Max(0, (card.Height - topOffset - block) / 2);
                circle.Top = top;
                circle.Left = (card.Width - circle.Width) / 2;
                t.Top = circle.Bottom + 8;
                t.Left = (card.Width - t.Width) / 2;
                s.Top = t.Bottom + 2;
                s.Left = (card.Width - s.Width) / 2;
            }
            card.Resize += (a, b) => DoLayout();
            DoLayout();
        }
    }
