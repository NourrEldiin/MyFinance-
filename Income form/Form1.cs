using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // ---------- Colors ----------
        static readonly Color AppBg = ColorTranslator.FromHtml("#F3F5FA");
        static readonly Color Navy = ColorTranslator.FromHtml("#16255A");
        static readonly Color NavActive = ColorTranslator.FromHtml("#3A4A82");
        static readonly Color NavHover = ColorTranslator.FromHtml("#243468");
        static readonly Color NavText = ColorTranslator.FromHtml("#C9D3F0");
        static readonly Color SideMuted = ColorTranslator.FromHtml("#9FB0DA");
        static readonly Color Blue = ColorTranslator.FromHtml("#3B82F6");
        static readonly Color Ink = ColorTranslator.FromHtml("#1B2340");
        static readonly Color Muted = ColorTranslator.FromHtml("#7C88A8");
        static readonly Color Mid = ColorTranslator.FromHtml("#5B6685");
        static readonly Color Border = ColorTranslator.FromHtml("#E5E9F2");
        static readonly Color IconBg = ColorTranslator.FromHtml("#EEF4FF");
        static readonly Color Placeholder = ColorTranslator.FromHtml("#B8C0D8");
        static readonly Color Ring = ColorTranslator.FromHtml("#DCE2F0");
        static readonly Color PlusGray = ColorTranslator.FromHtml("#C5CCE0");
        static readonly Color HeaderBg = ColorTranslator.FromHtml("#F7F9FC");

        Label txtIncome, txtExpenses, txtBalance;
        ComboBox cmbMonth;
        readonly List<RoundedPanel> navItems = new List<RoundedPanel>();
        RoundedPanel activeNav;

        public Form1()
        {
            InitializeComponent();
            BuildUI();
        }

        
        private void BuildUI()
        {
            Text = "MyFinance";
            ClientSize = new Size(1000, 720);
            MinimumSize = new Size(900, 660);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = AppBg;
            Font = new Font("Segoe UI", 9f);
            DoubleBuffered = true;

            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(20),
                BackColor = AppBg
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(root);

            var sidebar = new RoundedPanel
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                CornerRadius = 20,
                Corners = RoundedCorners.TopLeft | RoundedCorners.BottomLeft,
                FillColor = Navy
            };

            var main = new RoundedPanel
            {
                Dock = DockStyle.Fill,
                Margin = Padding.Empty,
                Padding = new Padding(24),
                CornerRadius = 20,
                Corners = RoundedCorners.TopRight | RoundedCorners.BottomRight,
                FillColor = Color.White
            };

            root.Controls.Add(sidebar, 0, 0);
            root.Controls.Add(main, 1, 0);

            BuildSidebar(sidebar);
            BuildMain(main);
        }

        
        private void BuildSidebar(RoundedPanel sidebar)
        {
            // Logo
            var logo = new RoundedPanel
            {
                Size = new Size(36, 36),
                Location = new Point(18, 24),
                CornerRadius = 9,
                FillColor = Blue
            };
            var m = MakeLabel("M", 13f, FontStyle.Bold, Color.White);
            m.AutoSize = false;
            m.Dock = DockStyle.Fill;
            m.TextAlign = ContentAlignment.MiddleCenter;
            logo.Controls.Add(m);

            var appName = MakeLabel("MyFinance", 11.5f, FontStyle.Bold, Color.White);
            appName.Location = new Point(62, 22);
            var appTag = MakeLabel("PERSONAL FINANCE", 6.5f, FontStyle.Regular, SideMuted);
            appTag.Location = new Point(63, 44);

            var menuTitle = MakeLabel("MAIN MENU", 7.5f, FontStyle.Bold, SideMuted);
            menuTitle.Location = new Point(22, 100);

            sidebar.Controls.AddRange(new Control[] { logo, appName, appTag, menuTitle });

            
            string[,] items =
            {
                { "D", "Dashboard" },
                { "I", "Income" },
                { "E", "Expenses" },
                { "B", "Budget" },
                { "R", "Reports" }
            };

            for (int i = 0; i < items.GetLength(0); i++)
            {
                var item = CreateNavItem(items[i, 0], items[i, 1], 124 + i * 46);
                navItems.Add(item);
                sidebar.Controls.Add(item);
            }
            SetActiveNav(navItems[0]);

            
            var line = new Panel { Height = 1, Width = 192, Left = 14, BackColor = Color.FromArgb(0x2E, 0x3E, 0x78) };

            var avatar = new RoundedPanel
            {
                Size = new Size(30, 30),
                Left = 18,
                CornerRadius = 15,
                FillColor = ColorTranslator.FromHtml("#E8EEFF")
            };
            var a = MakeLabel("A", 9f, FontStyle.Bold, Blue);
            a.AutoSize = false;
            a.Dock = DockStyle.Fill;
            a.TextAlign = ContentAlignment.MiddleCenter;
            avatar.Controls.Add(a);

            var userName = MakeLabel("Alex Morgan", 8f, FontStyle.Bold, Color.White);
            userName.Left = 56;
            var userType = MakeLabel("Personal Account", 7f, FontStyle.Regular, SideMuted);
            userType.Left = 57;

            sidebar.Controls.AddRange(new Control[] { line, avatar, userName, userType });

            void LayoutBottom()
            {
                int h = sidebar.Height;
                line.Top = h - 64;
                avatar.Top = h - 48;
                userName.Top = h - 48;
                userType.Top = h - 31;
            }
            sidebar.Resize += (s, e) => LayoutBottom();
            LayoutBottom();
        }

        private RoundedPanel CreateNavItem(string letter, string text, int y)
        {
            var item = new RoundedPanel
            {
                Size = new Size(192, 40),
                Location = new Point(14, y),
                CornerRadius = 10,
                FillColor = Navy,
                Cursor = Cursors.Hand
            };

            var l1 = MakeLabel(letter, 8f, FontStyle.Bold, NavText);
            l1.Location = new Point(16, 11);
            var l2 = MakeLabel(text, 9.5f, FontStyle.Regular, NavText);
            l2.Location = new Point(44, 9);
            item.Controls.Add(l1);
            item.Controls.Add(l2);

            foreach (Control c in new Control[] { item, l1, l2 })
            {
                c.Cursor = Cursors.Hand;
                c.MouseEnter += (s, e) => { if (item != activeNav) item.FillColor = NavHover; };
                c.MouseLeave += (s, e) =>
                {
                    if (item != activeNav &&
                        !item.ClientRectangle.Contains(item.PointToClient(Cursor.Position)))
                        item.FillColor = Navy;
                };
                c.Click += (s, e) => SetActiveNav(item);
            }
            return item;
        }

        private void SetActiveNav(RoundedPanel selected)
        {
            activeNav = selected;
            foreach (var nav in navItems)
            {
                bool active = nav == selected;
                nav.FillColor = active ? NavActive : Navy;
                foreach (var lbl in nav.Controls.OfType<Label>())
                    lbl.ForeColor = active ? Color.White : NavText;
            }
            
        }

        private void BuildMain(RoundedPanel main)
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

            layout.Controls.Add(BuildHeader(), 0, 0);
            layout.Controls.Add(BuildStatCards(), 0, 1);
            layout.Controls.Add(BuildChartCards(), 0, 2);
            layout.Controls.Add(BuildRecentTransactions(), 0, 3);
        }

        private Control BuildHeader()
        {
            var header = new Panel { Dock = DockStyle.Fill, Margin = Padding.Empty, BackColor = Color.White };

            var title = MakeLabel("Dashboard", 18f, FontStyle.Bold, Ink);
            title.Location = new Point(0, 0);
            var subtitle = MakeLabel("Your financial overview at a glance", 8.5f, FontStyle.Regular, Muted);
            subtitle.Location = new Point(2, 36);

            cmbMonth = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Width = 190,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.White,
                ForeColor = Mid,
                Font = new Font("Segoe UI", 8.5f),
                Top = 2
            };
            for (int i = 0; i < 12; i++)
                cmbMonth.Items.Add(DateTime.Today.AddMonths(-i).ToString("MMMM yyyy"));
            cmbMonth.SelectedIndex = 0;

            header.Controls.AddRange(new Control[] { title, subtitle, cmbMonth });
            header.Resize += (s, e) => cmbMonth.Left = header.Width - cmbMonth.Width;
            cmbMonth.Left = header.Width - cmbMonth.Width;
            return header;
        }

        private Control BuildStatCards()
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

            row.Controls.Add(CreateStatCard("Total Income", ColorTranslator.FromHtml("#3B82F6"),
                new Padding(0, 0, 8, 16), out txtIncome), 0, 0);
            row.Controls.Add(CreateStatCard("Total Expenses", ColorTranslator.FromHtml("#EF4466"),
                new Padding(8, 0, 8, 16), out txtExpenses), 1, 0);
            row.Controls.Add(CreateStatCard("Remaining Balance", ColorTranslator.FromHtml("#14B8A6"),
                new Padding(8, 0, 0, 16), out txtBalance), 2, 0);
            return row;
        }

        private RoundedPanel CreateStatCard(string title, Color dotColor, Padding margin, out Label valueLabel)
        {
            var card = NewCard(margin);

            var t = MakeLabel(title, 8.5f, FontStyle.Regular, Muted);
            t.Location = new Point(16, 14);

            valueLabel = MakeLabel("—", 16f, FontStyle.Bold, Placeholder);
            valueLabel.Location = new Point(16, 40);

            var icon = new RoundedPanel
            {
                Size = new Size(28, 28),
                Top = 12,
                CornerRadius = 8,
                FillColor = IconBg
            };
            icon.Controls.Add(new RoundedPanel
            {
                Size = new Size(6, 6),
                Location = new Point(11, 11),
                CornerRadius = 3,
                FillColor = dotColor
            });

            card.Controls.AddRange(new Control[] { t, valueLabel, icon });
            PinRight(card, icon, 14);
            return card;
        }

        private Control BuildChartCards()
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

            var left = NewCard(new Padding(0, 0, 8, 16));
            var lt = MakeLabel("Income vs. Expenses", 9f, FontStyle.Bold, Ink);
            lt.Location = new Point(16, 14);
            left.Controls.Add(lt);
            BuildEmptyState(left, "No transactions yet",
                "Add income and expenses to see your trends.", 44, 36);

            var right = NewCard(new Padding(8, 0, 0, 16));
            var rt = MakeLabel("Expenses by Category", 9f, FontStyle.Bold, Ink);
            rt.Location = new Point(16, 14);
            right.Controls.Add(rt);
            BuildEmptyState(right, "No expense data yet",
                "Your data will appear here when you add it.", 44, 36);

            row.Controls.Add(left, 0, 0);
            row.Controls.Add(right, 1, 0);
            return row;
        }

        private Control BuildRecentTransactions()
        {
            var card = NewCard(Padding.Empty);

            var title = MakeLabel("Recent Transactions", 9f, FontStyle.Bold, Ink);
            title.Location = new Point(16, 14);
            card.Controls.Add(title);

            // Table header
            var strip = new TableLayoutPanel
            {
                Location = new Point(16, 44),
                Height = 30,
                ColumnCount = 5,
                RowCount = 1,
                BackColor = HeaderBg
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
                    ForeColor = Muted
                }, i, 0);
            }
            strip.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var rule = new Panel { Location = new Point(16, 74), Height = 1, BackColor = Border };

            card.Controls.Add(strip);
            card.Controls.Add(rule);

            void LayoutTable()
            {
                strip.Width = Math.Max(0, card.Width - 32);
                rule.Width = strip.Width;
            }
            card.Resize += (s, e) => LayoutTable();
            LayoutTable();

            BuildEmptyState(card, "No transactions yet",
                "Your recent activity will appear here.", 36, 76);
            return card;
        }

        
        private static RoundedPanel NewCard(Padding margin)
        {
            return new RoundedPanel
            {
                Dock = DockStyle.Fill,
                Margin = margin,
                CornerRadius = 12,
                FillColor = Color.White,
                BorderColor = Border
            };
        }

        private static Label MakeLabel(string text, float size, FontStyle style, Color color)
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

        private static void PinRight(Control parent, Control child, int margin)
        {
            void Place() => child.Left = parent.Width - child.Width - margin;
            parent.Resize += (s, e) => Place();
            Place();
        }

        
        private static void BuildEmptyState(RoundedPanel card, string title, string subtitle,
                                            int circleSize, int topOffset)
        {
            var circle = new RoundedPanel
            {
                Size = new Size(circleSize, circleSize),
                CornerRadius = circleSize / 2,
                FillColor = Color.White,
                BorderColor = Ring
            };
            var plus = MakeLabel("+", circleSize > 40 ? 18f : 14f, FontStyle.Regular, PlusGray);
            plus.AutoSize = false;
            plus.Dock = DockStyle.Fill;
            plus.TextAlign = ContentAlignment.MiddleCenter;
            circle.Controls.Add(plus);

            var t = MakeLabel(title, 8.5f, FontStyle.Bold, Mid);
            var s = MakeLabel(subtitle, 7.5f, FontStyle.Regular, Muted);

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
}