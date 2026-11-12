
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MyFinance
{
    public partial class ExpensesForm : Form
    {
        private Dictionary<Button, Color> originalButtonColors =
            new Dictionary<Button, Color>();

            public ExpensesForm()
            {
                InitializeComponent();
                this.Load += ExpensesForm_Load;
            }

            public Panel GetPageContent()
            {
                ExpensesForm_Load(this, EventArgs.Empty);

                pnlSidebar.Visible = false;
                pnlMain.Location = Point.Empty;
                pnlMain.Dock = DockStyle.Fill;

                return pnlMain;
            }

        private GraphicsPath CreateRoundedPath(
            int width, int height, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.AddArc(0, 0, d, d, 180, 90);
            path.AddArc(width - d, 0, d, d, 270, 90);
            path.AddArc(width - d, height - d, d, d, 0, 90);
            path.AddArc(0, height - d, d, d, 90, 90);

            path.CloseFigure();

            return path;
        }

        private void MakeCircle(Control control)
        {
            if (control == null) return;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, control.Width, control.Height);
                control.Region = new Region(path);
            }
        }

        private void MakeRoundedPanel(Panel panel, int radius)
        {
            if (panel == null) return;

            using (GraphicsPath path =
                CreateRoundedPath(panel.Width, panel.Height, radius))
            {
                panel.Region = new Region(path);
            }
        }

        private void MakeRoundedButton(Button btn, int radius)
        {
            if (btn == null) return;

            using (GraphicsPath path =
                CreateRoundedPath(btn.Width, btn.Height, radius))
            {
                btn.Region = new Region(path);
            }
        }

        private void MakeRoundedControl(Control control, int radius)
        {
            if (control == null) return;

            using (GraphicsPath path =
                CreateRoundedPath(control.Width, control.Height, radius))
            {
                control.Region = new Region(path);
            }
        }

        private void ExpensesForm_Load(object? sender, EventArgs e)
        {
            // Logo M: rounded square
            MakeRoundedPanel(pnlLogo, 8);

            // Profile S: circular
            MakeCircle(pnlProfile);

            // Rounded summary cards
            MakeRoundedPanel(pnlTotalExpenses, 12);
            MakeRoundedPanel(pnlTransactionsCount, 12);
            MakeRoundedPanel(pnlTopCategory, 12);

            // Rounded table container
            MakeRoundedPanel(pnlExpensesTable, 12);

            // Add Expense button
            MakeRoundedButton(btnAddExpenses, 12);

            txtSearchExpense.BorderStyle = BorderStyle.None;
            txtSearchExpense.BackColor = Color.White;
            txtSearchExpense.ForeColor = Color.FromArgb(32, 43, 60);
            MakeRoundedControl(txtSearchExpense, 8);

            // Soft borders for cards
            pnlTotalExpenses.BorderStyle = BorderStyle.None;
            pnlTransactionsCount.BorderStyle = BorderStyle.None;
            pnlTopCategory.BorderStyle = BorderStyle.None;
            pnlExpensesTable.BorderStyle = BorderStyle.None;

            pnlTotalExpenses.Paint += DrawSoftBorder;
            pnlTransactionsCount.Paint += DrawSoftBorder;
            pnlTopCategory.Paint += DrawSoftBorder;
            pnlExpensesTable.Paint += DrawSoftBorder;

            // Search border
            pnlMain.Paint += DrawSearchBorder;

            // Sidebar hover effects
            SetupSidebarHover(pnlSidebar);
        }

        private void DrawSoftBorder(object? sender, PaintEventArgs e)
        {
            if (sender is not Control control) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(
                Color.FromArgb(225, 232, 241), 1))
            using (GraphicsPath path = CreateRoundedPath(
                control.Width - 1, control.Height - 1, 12))
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        private void DrawSearchBorder(object? sender, PaintEventArgs e)
        {
            if (txtSearchExpense == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = txtSearchExpense.Bounds;
            rect.Inflate(1, 1);

            using (Pen pen = new Pen(
                Color.FromArgb(225, 232, 241), 1))
            using (GraphicsPath path = CreateRoundedPath(
                rect.Width - 1, rect.Height - 1, 10))
            {
                e.Graphics.DrawPath(
                    pen, TransformPath(path, rect.X, rect.Y));
            }
        }

        private GraphicsPath TransformPath(
            GraphicsPath path, int x, int y)
        {
            GraphicsPath newPath = (GraphicsPath)path.Clone();

            using (Matrix matrix = new Matrix())
            {
                matrix.Translate(x, y);
                newPath.Transform(matrix);
            }

            return newPath;
        }

        // Sidebar hover setup
        private void SetupSidebarHover(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn)
                {
                    originalButtonColors[btn] = btn.BackColor;

                    MakeRoundedButton(btn, 8);

                    btn.MouseEnter += Sidebar_MouseEnter;
                    btn.MouseLeave += Sidebar_MouseLeave;
                }

                SetupSidebarHover(control);
            }
        }

        private void Sidebar_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            btn.BackColor = Color.FromArgb(43, 59, 84);
            MakeRoundedButton(btn, 8);
        }

        private void Sidebar_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            if (originalButtonColors.ContainsKey(btn))
            {
                btn.BackColor = originalButtonColors[btn];
            }

            MakeRoundedButton(btn, 8);
        }

        private void lblLogo_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void lblSubtitle_Click(object sender, EventArgs e) { }
        private void lblI_Click(object sender, EventArgs e) { }
        private void lblE_Click(object sender, EventArgs e) { }
        private void btnBudget_Click(object sender, EventArgs e) { }
        private void lblB_Click(object sender, EventArgs e) { }
        private void lblR_Click(object sender, EventArgs e) { }
        private void pnlProfile_Paint(object sender, PaintEventArgs e) { }
        private void lblProfileInitial_Click(object sender, EventArgs e) { }
        private void lblTransactionsTitle_Click(object sender, EventArgs e) { }
        private void lblTransactionsIcon_Click(object sender, EventArgs e) { }
        private void lblTopCategoryTitle_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        { }
        private void label3_Click(object sender, EventArgs e) { }
        private void pnlExpensesTable_Paint(
            object sender, PaintEventArgs e)
        { }

        private void lblEmptyIcon_Click(object sender, EventArgs e)
        {
        }
    }
}
