using System;
using System.Drawing;
using System.Windows.Forms;

namespace PersonalFinanceUI
{

partial class IncomeForm
{
    private System.ComponentModel.IContainer components = null;
    private Panel sidebarPanel = null;
    private Panel brandPanel = null;
    private Label brandMarkLabel = null;
    private Label brandNameLabel = null;
    private Label brandCaptionLabel = null;
    private Label menuCaptionLabel = null;
    private FlowLayoutPanel navigationPanel = null;
    private Button dashboardButton = null;
    private Button incomeNavButton = null;
    private Button expensesButton = null;
    private Button budgetButton = null;
    private Button reportsButton = null;
    private Panel profilePanel = null;
    private Label profileInitialLabel = null;
    private Label profileNameLabel = null;
    private Label profileCaptionLabel = null;
    private Panel mainPanel = null;
    private Panel headerPanel = null;
    private Label pageTitleLabel = null;
    private Label pageDescriptionLabel = null;
    private ComboBox monthComboBox = null;
    private TableLayoutPanel cardsLayout = null;
    private Panel totalIncomeCard = null;
    private Panel transactionsCard = null;
    private Panel topSourceCard = null;
    private Label totalIncomeTitle = null;
    private Label transactionsTitle = null;
    private Label topSourceTitle = null;
    private Label totalIncomeValue = null;
    private Label transactionsValue = null;
    private Label topSourceValue = null;
    private Label totalIncomeBadge = null;
    private Label transactionsBadge = null;
    private Label topSourceBadge = null;
    private Panel toolbarPanel = null;
    private TextBox searchTextBox = null;
    private Button addIncomeButton = null;
    private Panel transactionsPanel = null;
    private Label transactionsHeaderLabel = null;
    private DataGridView incomeGrid = null;
    private Panel emptyStatePanel = null;
    private Label emptyIconLabel = null;
    private Label emptyTitleLabel = null;
    private Label emptyDescriptionLabel = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            sidebarPanel = new Panel();
            profilePanel = new Panel();
            profileCaptionLabel = new Label();
            profileNameLabel = new Label();
            profileInitialLabel = new Label();
            navigationPanel = new FlowLayoutPanel();
            dashboardButton = new Button();
            incomeNavButton = new Button();
            expensesButton = new Button();
            budgetButton = new Button();
            reportsButton = new Button();
            menuCaptionLabel = new Label();
            brandPanel = new Panel();
            brandCaptionLabel = new Label();
            brandNameLabel = new Label();
            brandMarkLabel = new Label();
            mainPanel = new Panel();
            transactionsPanel = new Panel();
            emptyStatePanel = new Panel();
            emptyDescriptionLabel = new Label();
            emptyTitleLabel = new Label();
            emptyIconLabel = new Label();
            incomeGrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            transactionsHeaderLabel = new Label();
            toolbarPanel = new Panel();
            searchTextBox = new TextBox();
            addIncomeButton = new Button();
            cardsLayout = new TableLayoutPanel();
            totalIncomeCard = new Panel();
            totalIncomeTitle = new Label();
            totalIncomeValue = new Label();
            totalIncomeBadge = new Label();
            transactionsCard = new Panel();
            transactionsTitle = new Label();
            transactionsValue = new Label();
            transactionsBadge = new Label();
            topSourceCard = new Panel();
            topSourceTitle = new Label();
            topSourceValue = new Label();
            topSourceBadge = new Label();
            headerPanel = new Panel();
            pageTitleLabel = new Label();
            pageDescriptionLabel = new Label();
            monthComboBox = new ComboBox();
            sidebarPanel.SuspendLayout();
            profilePanel.SuspendLayout();
            navigationPanel.SuspendLayout();
            brandPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            transactionsPanel.SuspendLayout();
            emptyStatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)incomeGrid).BeginInit();
            toolbarPanel.SuspendLayout();
            cardsLayout.SuspendLayout();
            totalIncomeCard.SuspendLayout();
            transactionsCard.SuspendLayout();
            topSourceCard.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(23, 37, 84);
            sidebarPanel.Controls.Add(profilePanel);
            sidebarPanel.Controls.Add(navigationPanel);
            sidebarPanel.Controls.Add(menuCaptionLabel);
            sidebarPanel.Controls.Add(brandPanel);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(247, 800);
            sidebarPanel.TabIndex = 1;
            // 
            // profilePanel
            // 
            profilePanel.Controls.Add(profileCaptionLabel);
            profilePanel.Controls.Add(profileNameLabel);
            profilePanel.Controls.Add(profileInitialLabel);
            profilePanel.Dock = DockStyle.Bottom;
            profilePanel.Location = new Point(0, 726);
            profilePanel.Name = "profilePanel";
            profilePanel.Padding = new Padding(12, 13, 5, 5);
            profilePanel.Size = new Size(247, 74);
            profilePanel.TabIndex = 0;
            // 
            // profileCaptionLabel
            // 
            profileCaptionLabel.AutoSize = true;
            profileCaptionLabel.Font = new Font("Segoe UI", 8F);
            profileCaptionLabel.ForeColor = Color.FromArgb(181, 195, 223);
            profileCaptionLabel.Location = new Point(60, 37);
            profileCaptionLabel.Name = "profileCaptionLabel";
            profileCaptionLabel.Size = new Size(114, 19);
            profileCaptionLabel.TabIndex = 0;
            profileCaptionLabel.Text = "Personal Account";
            // 
            // profileNameLabel
            // 
            profileNameLabel.AutoSize = true;
            profileNameLabel.Font = new Font("Segoe UI", 9F);
            profileNameLabel.ForeColor = Color.White;
            profileNameLabel.Location = new Point(60, 17);
            profileNameLabel.Name = "profileNameLabel";
            profileNameLabel.Size = new Size(83, 20);
            profileNameLabel.TabIndex = 1;
            profileNameLabel.Text = "Demo User";
            // 
            // profileInitialLabel
            // 
            profileInitialLabel.BackColor = Color.FromArgb(219, 234, 254);
            profileInitialLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            profileInitialLabel.ForeColor = Color.FromArgb(29, 78, 216);
            profileInitialLabel.Location = new Point(12, 17);
            profileInitialLabel.Name = "profileInitialLabel";
            profileInitialLabel.Size = new Size(38, 38);
            profileInitialLabel.TabIndex = 2;
            profileInitialLabel.Text = "M";
            profileInitialLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.Transparent;
            navigationPanel.Controls.Add(dashboardButton);
            navigationPanel.Controls.Add(incomeNavButton);
            navigationPanel.Controls.Add(expensesButton);
            navigationPanel.Controls.Add(budgetButton);
            navigationPanel.Controls.Add(reportsButton);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.FlowDirection = FlowDirection.TopDown;
            navigationPanel.Location = new Point(0, 94);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Padding = new Padding(4, 34, 4, 0);
            navigationPanel.Size = new Size(247, 300);
            navigationPanel.TabIndex = 1;
            navigationPanel.WrapContents = false;
            navigationPanel.Paint += navigationPanel_Paint;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.FromArgb(23, 37, 84);
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Segoe UI", 10F);
            dashboardButton.ForeColor = Color.FromArgb(207, 218, 238);
            dashboardButton.Location = new Point(4, 36);
            dashboardButton.Margin = new Padding(0, 2, 0, 2);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(13, 0, 0, 0);
            dashboardButton.Size = new Size(229, 45);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "   D      Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += NavButton_Click;
            // 
            // incomeNavButton
            // 
            incomeNavButton.BackColor = Color.FromArgb(54, 73, 122);
            incomeNavButton.FlatAppearance.BorderSize = 0;
            incomeNavButton.FlatStyle = FlatStyle.Flat;
            incomeNavButton.Font = new Font("Segoe UI", 10F);
            incomeNavButton.ForeColor = Color.White;
            incomeNavButton.Location = new Point(4, 85);
            incomeNavButton.Margin = new Padding(0, 2, 0, 2);
            incomeNavButton.Name = "incomeNavButton";
            incomeNavButton.Padding = new Padding(13, 0, 0, 0);
            incomeNavButton.Size = new Size(229, 45);
            incomeNavButton.TabIndex = 1;
            incomeNavButton.Text = "   I      Income";
            incomeNavButton.TextAlign = ContentAlignment.MiddleLeft;
            incomeNavButton.UseVisualStyleBackColor = false;
            incomeNavButton.Click += NavButton_Click;
            // 
            // expensesButton
            // 
            expensesButton.BackColor = Color.FromArgb(23, 37, 84);
            expensesButton.FlatAppearance.BorderSize = 0;
            expensesButton.FlatStyle = FlatStyle.Flat;
            expensesButton.Font = new Font("Segoe UI", 10F);
            expensesButton.ForeColor = Color.FromArgb(207, 218, 238);
            expensesButton.Location = new Point(4, 134);
            expensesButton.Margin = new Padding(0, 2, 0, 2);
            expensesButton.Name = "expensesButton";
            expensesButton.Padding = new Padding(13, 0, 0, 0);
            expensesButton.Size = new Size(229, 45);
            expensesButton.TabIndex = 2;
            expensesButton.Text = "   E      Expenses";
            expensesButton.TextAlign = ContentAlignment.MiddleLeft;
            expensesButton.UseVisualStyleBackColor = false;
            expensesButton.Click += NavButton_Click;
            // 
            // budgetButton
            // 
            budgetButton.BackColor = Color.FromArgb(23, 37, 84);
            budgetButton.FlatAppearance.BorderSize = 0;
            budgetButton.FlatStyle = FlatStyle.Flat;
            budgetButton.Font = new Font("Segoe UI", 10F);
            budgetButton.ForeColor = Color.FromArgb(207, 218, 238);
            budgetButton.Location = new Point(4, 183);
            budgetButton.Margin = new Padding(0, 2, 0, 2);
            budgetButton.Name = "budgetButton";
            budgetButton.Padding = new Padding(13, 0, 0, 0);
            budgetButton.Size = new Size(229, 45);
            budgetButton.TabIndex = 3;
            budgetButton.Text = "   B      Budget";
            budgetButton.TextAlign = ContentAlignment.MiddleLeft;
            budgetButton.UseVisualStyleBackColor = false;
            budgetButton.Click += NavButton_Click;
            // 
            // reportsButton
            // 
            reportsButton.BackColor = Color.FromArgb(23, 37, 84);
            reportsButton.FlatAppearance.BorderSize = 0;
            reportsButton.FlatStyle = FlatStyle.Flat;
            reportsButton.Font = new Font("Segoe UI", 10F);
            reportsButton.ForeColor = Color.FromArgb(207, 218, 238);
            reportsButton.Location = new Point(4, 232);
            reportsButton.Margin = new Padding(0, 2, 0, 2);
            reportsButton.Name = "reportsButton";
            reportsButton.Padding = new Padding(13, 0, 0, 0);
            reportsButton.Size = new Size(229, 45);
            reportsButton.TabIndex = 4;
            reportsButton.Text = "   R      Reports";
            reportsButton.TextAlign = ContentAlignment.MiddleLeft;
            reportsButton.UseVisualStyleBackColor = false;
            reportsButton.Click += NavButton_Click;
            // 
            // menuCaptionLabel
            // 
            menuCaptionLabel.AutoSize = true;
            menuCaptionLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            menuCaptionLabel.ForeColor = Color.FromArgb(158, 175, 208);
            menuCaptionLabel.Location = new Point(14, 112);
            menuCaptionLabel.Name = "menuCaptionLabel";
            menuCaptionLabel.Size = new Size(92, 19);
            menuCaptionLabel.TabIndex = 2;
            menuCaptionLabel.Text = "MAIN MENU";
            // 
            // brandPanel
            // 
            brandPanel.Controls.Add(brandCaptionLabel);
            brandPanel.Controls.Add(brandNameLabel);
            brandPanel.Controls.Add(brandMarkLabel);
            brandPanel.Dock = DockStyle.Top;
            brandPanel.Location = new Point(0, 0);
            brandPanel.Name = "brandPanel";
            brandPanel.Padding = new Padding(12, 18, 8, 10);
            brandPanel.Size = new Size(247, 94);
            brandPanel.TabIndex = 3;
            // 
            // brandCaptionLabel
            // 
            brandCaptionLabel.AutoSize = true;
            brandCaptionLabel.Font = new Font("Segoe UI", 8F);
            brandCaptionLabel.ForeColor = Color.FromArgb(181, 195, 223);
            brandCaptionLabel.Location = new Point(75, 47);
            brandCaptionLabel.Name = "brandCaptionLabel";
            brandCaptionLabel.Size = new Size(136, 19);
            brandCaptionLabel.TabIndex = 0;
            brandCaptionLabel.Text = "PERSONAL FINANCE";
            // 
            // brandNameLabel
            // 
            brandNameLabel.AutoSize = true;
            brandNameLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            brandNameLabel.ForeColor = Color.White;
            brandNameLabel.Location = new Point(74, 20);
            brandNameLabel.Name = "brandNameLabel";
            brandNameLabel.Size = new Size(141, 35);
            brandNameLabel.TabIndex = 1;
            brandNameLabel.Text = "MyFinance";
            // 
            // brandMarkLabel
            // 
            brandMarkLabel.BackColor = Color.FromArgb(59, 130, 246);
            brandMarkLabel.BorderStyle = BorderStyle.FixedSingle;
            brandMarkLabel.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            brandMarkLabel.ForeColor = Color.White;
            brandMarkLabel.Location = new Point(12, 19);
            brandMarkLabel.Name = "brandMarkLabel";
            brandMarkLabel.Size = new Size(50, 50);
            brandMarkLabel.TabIndex = 2;
            brandMarkLabel.Text = "M";
            brandMarkLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(transactionsPanel);
            mainPanel.Controls.Add(toolbarPanel);
            mainPanel.Controls.Add(cardsLayout);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(247, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(36, 24, 30, 0);
            mainPanel.Size = new Size(1033, 800);
            mainPanel.TabIndex = 0;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // transactionsPanel
            // 
            transactionsPanel.BorderStyle = BorderStyle.FixedSingle;
            transactionsPanel.Controls.Add(emptyStatePanel);
            transactionsPanel.Controls.Add(incomeGrid);
            transactionsPanel.Controls.Add(transactionsHeaderLabel);
            transactionsPanel.Dock = DockStyle.Fill;
            transactionsPanel.Location = new Point(36, 302);
            transactionsPanel.Name = "transactionsPanel";
            transactionsPanel.Padding = new Padding(16);
            transactionsPanel.Size = new Size(967, 498);
            transactionsPanel.TabIndex = 0;
            // 
            // emptyStatePanel
            // 
            emptyStatePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            emptyStatePanel.BackColor = Color.White;
            emptyStatePanel.Controls.Add(emptyDescriptionLabel);
            emptyStatePanel.Controls.Add(emptyTitleLabel);
            emptyStatePanel.Controls.Add(emptyIconLabel);
            emptyStatePanel.Location = new Point(16, 95);
            emptyStatePanel.Name = "emptyStatePanel";
            emptyStatePanel.Size = new Size(935, 386);
            emptyStatePanel.TabIndex = 0;
            // 
            // emptyDescriptionLabel
            // 
            emptyDescriptionLabel.Anchor = AnchorStyles.None;
            emptyDescriptionLabel.AutoSize = true;
            emptyDescriptionLabel.Font = new Font("Segoe UI", 8F);
            emptyDescriptionLabel.ForeColor = Color.FromArgb(135, 146, 165);
            emptyDescriptionLabel.Location = new Point(316, 225);
            emptyDescriptionLabel.Name = "emptyDescriptionLabel";
            emptyDescriptionLabel.Size = new Size(302, 19);
            emptyDescriptionLabel.TabIndex = 0;
            emptyDescriptionLabel.Text = "Select \"Add Income\" to record your first income.";
            // 
            // emptyTitleLabel
            // 
            emptyTitleLabel.Anchor = AnchorStyles.None;
            emptyTitleLabel.AutoSize = true;
            emptyTitleLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            emptyTitleLabel.ForeColor = Color.FromArgb(100, 116, 139);
            emptyTitleLabel.Location = new Point(383, 200);
            emptyTitleLabel.Name = "emptyTitleLabel";
            emptyTitleLabel.Size = new Size(182, 23);
            emptyTitleLabel.TabIndex = 1;
            emptyTitleLabel.Text = "No income added yet";
            // 
            // emptyIconLabel
            // 
            emptyIconLabel.Anchor = AnchorStyles.None;
            emptyIconLabel.Font = new Font("Segoe UI Light", 34F);
            emptyIconLabel.ForeColor = Color.FromArgb(214, 226, 245);
            emptyIconLabel.Location = new Point(445, 140);
            emptyIconLabel.Name = "emptyIconLabel";
            emptyIconLabel.Size = new Size(58, 58);
            emptyIconLabel.TabIndex = 2;
            emptyIconLabel.Text = "+";
            emptyIconLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // incomeGrid
            // 
            incomeGrid.AllowUserToAddRows = false;
            incomeGrid.AllowUserToDeleteRows = false;
            incomeGrid.AllowUserToResizeRows = false;
            incomeGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            incomeGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            incomeGrid.BackgroundColor = Color.White;
            incomeGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(135, 146, 165);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            incomeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            incomeGrid.ColumnHeadersHeight = 38;
            incomeGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(24, 34, 48);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            incomeGrid.DefaultCellStyle = dataGridViewCellStyle4;
            incomeGrid.EnableHeadersVisualStyles = false;
            incomeGrid.GridColor = Color.FromArgb(237, 240, 245);
            incomeGrid.Location = new Point(16, 56);
            incomeGrid.Name = "incomeGrid";
            incomeGrid.ReadOnly = true;
            incomeGrid.RowHeadersVisible = false;
            incomeGrid.RowHeadersWidth = 51;
            incomeGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            incomeGrid.Size = new Size(935, 39);
            incomeGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Source";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Category";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Date";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Notes";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Amount";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Actions";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // transactionsHeaderLabel
            // 
            transactionsHeaderLabel.AutoSize = true;
            transactionsHeaderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            transactionsHeaderLabel.ForeColor = Color.FromArgb(24, 34, 48);
            transactionsHeaderLabel.Location = new Point(20, 17);
            transactionsHeaderLabel.Name = "transactionsHeaderLabel";
            transactionsHeaderLabel.Size = new Size(171, 23);
            transactionsHeaderLabel.TabIndex = 2;
            transactionsHeaderLabel.Text = "Income Transactions";
            // 
            // toolbarPanel
            // 
            toolbarPanel.Controls.Add(searchTextBox);
            toolbarPanel.Controls.Add(addIncomeButton);
            toolbarPanel.Dock = DockStyle.Top;
            toolbarPanel.Location = new Point(36, 216);
            toolbarPanel.Name = "toolbarPanel";
            toolbarPanel.Padding = new Padding(0, 27, 0, 0);
            toolbarPanel.Size = new Size(967, 86);
            toolbarPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 9F);
            searchTextBox.ForeColor = Color.FromArgb(135, 146, 165);
            searchTextBox.Location = new Point(0, 27);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(270, 27);
            searchTextBox.TabIndex = 0;
            searchTextBox.Text = "Search income...";
            // 
            // addIncomeButton
            // 
            addIncomeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addIncomeButton.BackColor = Color.FromArgb(59, 130, 246);
            addIncomeButton.FlatAppearance.BorderSize = 0;
            addIncomeButton.FlatStyle = FlatStyle.Flat;
            addIncomeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addIncomeButton.ForeColor = Color.White;
            addIncomeButton.Location = new Point(752, 27);
            addIncomeButton.Name = "addIncomeButton";
            addIncomeButton.Size = new Size(170, 40);
            addIncomeButton.TabIndex = 1;
            addIncomeButton.Text = "+  Add Income";
            addIncomeButton.UseVisualStyleBackColor = false;
            addIncomeButton.Click += AddIncomeButton_Click;
            // 
            // cardsLayout
            // 
            cardsLayout.ColumnCount = 3;
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            cardsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.334F));
            cardsLayout.Controls.Add(totalIncomeCard, 0, 0);
            cardsLayout.Controls.Add(transactionsCard, 1, 0);
            cardsLayout.Controls.Add(topSourceCard, 2, 0);
            cardsLayout.Dock = DockStyle.Top;
            cardsLayout.Location = new Point(36, 102);
            cardsLayout.Name = "cardsLayout";
            cardsLayout.RowCount = 1;
            cardsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            cardsLayout.Size = new Size(967, 114);
            cardsLayout.TabIndex = 2;
            // 
            // totalIncomeCard
            // 
            totalIncomeCard.BackColor = Color.White;
            totalIncomeCard.BorderStyle = BorderStyle.FixedSingle;
            totalIncomeCard.Controls.Add(totalIncomeTitle);
            totalIncomeCard.Controls.Add(totalIncomeValue);
            totalIncomeCard.Controls.Add(totalIncomeBadge);
            totalIncomeCard.Location = new Point(0, 0);
            totalIncomeCard.Margin = new Padding(0, 0, 14, 0);
            totalIncomeCard.Name = "totalIncomeCard";
            totalIncomeCard.Padding = new Padding(18, 18, 12, 10);
            totalIncomeCard.Size = new Size(200, 100);
            totalIncomeCard.TabIndex = 0;
            // 
            // totalIncomeTitle
            // 
            totalIncomeTitle.AutoSize = true;
            totalIncomeTitle.Font = new Font("Segoe UI", 9F);
            totalIncomeTitle.ForeColor = Color.FromArgb(135, 146, 165);
            totalIncomeTitle.Location = new Point(17, 17);
            totalIncomeTitle.Name = "totalIncomeTitle";
            totalIncomeTitle.Size = new Size(172, 20);
            totalIncomeTitle.TabIndex = 0;
            totalIncomeTitle.Text = "Total Income This Month";
            // 
            // totalIncomeValue
            // 
            totalIncomeValue.AutoSize = true;
            totalIncomeValue.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            totalIncomeValue.ForeColor = Color.FromArgb(199, 207, 218);
            totalIncomeValue.Location = new Point(17, 53);
            totalIncomeValue.Name = "totalIncomeValue";
            totalIncomeValue.Size = new Size(46, 40);
            totalIncomeValue.TabIndex = 1;
            totalIncomeValue.Text = "—";
            // 
            // totalIncomeBadge
            // 
            totalIncomeBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalIncomeBadge.BackColor = Color.FromArgb(239, 246, 255);
            totalIncomeBadge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            totalIncomeBadge.ForeColor = Color.FromArgb(59, 130, 246);
            totalIncomeBadge.Location = new Point(238, 17);
            totalIncomeBadge.Name = "totalIncomeBadge";
            totalIncomeBadge.Size = new Size(40, 40);
            totalIncomeBadge.TabIndex = 2;
            totalIncomeBadge.Text = "•";
            totalIncomeBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // transactionsCard
            // 
            transactionsCard.BackColor = Color.White;
            transactionsCard.BorderStyle = BorderStyle.FixedSingle;
            transactionsCard.Controls.Add(transactionsTitle);
            transactionsCard.Controls.Add(transactionsValue);
            transactionsCard.Controls.Add(transactionsBadge);
            transactionsCard.Location = new Point(322, 0);
            transactionsCard.Margin = new Padding(0, 0, 14, 0);
            transactionsCard.Name = "transactionsCard";
            transactionsCard.Padding = new Padding(18, 18, 12, 10);
            transactionsCard.Size = new Size(200, 100);
            transactionsCard.TabIndex = 1;
            // 
            // transactionsTitle
            // 
            transactionsTitle.AutoSize = true;
            transactionsTitle.Font = new Font("Segoe UI", 9F);
            transactionsTitle.ForeColor = Color.FromArgb(135, 146, 165);
            transactionsTitle.Location = new Point(17, 17);
            transactionsTitle.Name = "transactionsTitle";
            transactionsTitle.Size = new Size(143, 20);
            transactionsTitle.TabIndex = 0;
            transactionsTitle.Text = "Income Transactions";
            // 
            // transactionsValue
            // 
            transactionsValue.AutoSize = true;
            transactionsValue.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            transactionsValue.ForeColor = Color.FromArgb(199, 207, 218);
            transactionsValue.Location = new Point(17, 53);
            transactionsValue.Name = "transactionsValue";
            transactionsValue.Size = new Size(46, 40);
            transactionsValue.TabIndex = 1;
            transactionsValue.Text = "—";
            // 
            // transactionsBadge
            // 
            transactionsBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            transactionsBadge.BackColor = Color.FromArgb(239, 246, 255);
            transactionsBadge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            transactionsBadge.ForeColor = Color.FromArgb(59, 130, 246);
            transactionsBadge.Location = new Point(238, 17);
            transactionsBadge.Name = "transactionsBadge";
            transactionsBadge.Size = new Size(40, 40);
            transactionsBadge.TabIndex = 2;
            transactionsBadge.Text = "•";
            transactionsBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topSourceCard
            // 
            topSourceCard.BackColor = Color.White;
            topSourceCard.BorderStyle = BorderStyle.FixedSingle;
            topSourceCard.Controls.Add(topSourceTitle);
            topSourceCard.Controls.Add(topSourceValue);
            topSourceCard.Controls.Add(topSourceBadge);
            topSourceCard.Location = new Point(644, 0);
            topSourceCard.Margin = new Padding(0, 0, 14, 0);
            topSourceCard.Name = "topSourceCard";
            topSourceCard.Padding = new Padding(18, 18, 12, 10);
            topSourceCard.Size = new Size(200, 100);
            topSourceCard.TabIndex = 2;
            // 
            // topSourceTitle
            // 
            topSourceTitle.AutoSize = true;
            topSourceTitle.Font = new Font("Segoe UI", 9F);
            topSourceTitle.ForeColor = Color.FromArgb(135, 146, 165);
            topSourceTitle.Location = new Point(17, 17);
            topSourceTitle.Name = "topSourceTitle";
            topSourceTitle.Size = new Size(136, 20);
            topSourceTitle.TabIndex = 0;
            topSourceTitle.Text = "Top Income Source";
            // 
            // topSourceValue
            // 
            topSourceValue.AutoSize = true;
            topSourceValue.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            topSourceValue.ForeColor = Color.FromArgb(199, 207, 218);
            topSourceValue.Location = new Point(17, 53);
            topSourceValue.Name = "topSourceValue";
            topSourceValue.Size = new Size(46, 40);
            topSourceValue.TabIndex = 1;
            topSourceValue.Text = "—";
            // 
            // topSourceBadge
            // 
            topSourceBadge.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            topSourceBadge.BackColor = Color.FromArgb(239, 246, 255);
            topSourceBadge.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            topSourceBadge.ForeColor = Color.FromArgb(59, 130, 246);
            topSourceBadge.Location = new Point(238, 17);
            topSourceBadge.Name = "topSourceBadge";
            topSourceBadge.Size = new Size(40, 40);
            topSourceBadge.TabIndex = 2;
            topSourceBadge.Text = "•";
            topSourceBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(pageTitleLabel);
            headerPanel.Controls.Add(pageDescriptionLabel);
            headerPanel.Controls.Add(monthComboBox);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(36, 24);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(967, 78);
            headerPanel.TabIndex = 3;
            // 
            // pageTitleLabel
            // 
            pageTitleLabel.AutoSize = true;
            pageTitleLabel.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            pageTitleLabel.ForeColor = Color.FromArgb(24, 34, 48);
            pageTitleLabel.Location = new Point(0, 0);
            pageTitleLabel.Name = "pageTitleLabel";
            pageTitleLabel.Size = new Size(141, 47);
            pageTitleLabel.TabIndex = 0;
            pageTitleLabel.Text = "Income";
            // 
            // pageDescriptionLabel
            // 
            pageDescriptionLabel.AutoSize = true;
            pageDescriptionLabel.Font = new Font("Segoe UI", 10F);
            pageDescriptionLabel.ForeColor = Color.FromArgb(135, 146, 165);
            pageDescriptionLabel.Location = new Point(1, 42);
            pageDescriptionLabel.Name = "pageDescriptionLabel";
            pageDescriptionLabel.Size = new Size(312, 23);
            pageDescriptionLabel.TabIndex = 1;
            pageDescriptionLabel.Text = "Track and manage your income sources";
            // 
            // monthComboBox
            // 
            monthComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            monthComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComboBox.Font = new Font("Segoe UI", 9F);
            monthComboBox.ForeColor = Color.FromArgb(101, 113, 135);
            monthComboBox.Items.AddRange(new object[] { "November 2026", "October 2026", "September 2026" });
            monthComboBox.Location = new Point(1517, 0);
            monthComboBox.Name = "monthComboBox";
            monthComboBox.Size = new Size(202, 28);
            monthComboBox.TabIndex = 2;
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 800);
            Controls.Add(mainPanel);
            Controls.Add(sidebarPanel);
            MinimumSize = new Size(1000, 700);
            Name = "IncomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyFinance — Income";
            Load += IncomeForm_Load;
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            profilePanel.ResumeLayout(false);
            profilePanel.PerformLayout();
            navigationPanel.ResumeLayout(false);
            brandPanel.ResumeLayout(false);
            brandPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            transactionsPanel.ResumeLayout(false);
            transactionsPanel.PerformLayout();
            emptyStatePanel.ResumeLayout(false);
            emptyStatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)incomeGrid).EndInit();
            toolbarPanel.ResumeLayout(false);
            toolbarPanel.PerformLayout();
            cardsLayout.ResumeLayout(false);
            totalIncomeCard.ResumeLayout(false);
            totalIncomeCard.PerformLayout();
            transactionsCard.ResumeLayout(false);
            transactionsCard.PerformLayout();
            topSourceCard.ResumeLayout(false);
            topSourceCard.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}

