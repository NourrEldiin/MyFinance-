using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyFinance
{
    public partial class IncomeForm : Form
    {
        public IncomeForm()
        {
            InitializeComponent();
        }

        public Panel GetPageContent()
        {
            sidebarPanel.Visible = false;
            mainPanel.Location = Point.Empty;
            mainPanel.Dock = DockStyle.Fill;

            return mainPanel;
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in navigationPanel.Controls)
            {
                Button? button = control as Button;
                if (button != null)
                {
                    button.BackColor = Color.FromArgb(23, 37, 84);
                    button.ForeColor = Color.FromArgb(207, 218, 238);
                }
            }

            Button? selected = sender as Button;
            if (selected != null)
            {
                selected.BackColor = Color.FromArgb(54, 73, 122);
                selected.ForeColor = Color.White;
            }
        }

        private void AddIncomeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Income form will be connected in the next step.", "MyFinance",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void navigationPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalIncomeTitle_Click(object sender, EventArgs e)
        {

        }

        private void pageTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void IncomeForm_Load(object sender, EventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
