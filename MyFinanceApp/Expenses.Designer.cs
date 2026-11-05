namespace WinFormsApp2
{
    partial class ExpensesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlSidebar = new Panel();
            label2 = new Label();
            lblProfileName = new Label();
            pnlProfile = new Panel();
            lblProfileInitial = new Label();
            pnlSeparator = new Panel();
            lblR = new Label();
            btnReports = new Button();
            lblB = new Label();
            btnBudget = new Button();
            lblE = new Label();
            btnExpenses = new Button();
            lblI = new Label();
            btnIncome = new Button();
            lblD = new Label();
            button1 = new Button();
            lblMainMenu = new Label();
            lblSubtitle = new Label();
            pnlLogo = new Panel();
            label1 = new Label();
            lblLogo = new Label();
            pnlMain = new Panel();
            pnlExpensesTable = new Panel();
            lblEmptyDescription = new Label();
            label5 = new Label();
            lblEmptyIcon = new Label();
            dgvExpenses = new DataGridView();
            colExpenseName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colPaymentMethod = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            label3 = new Label();
            btnAddExpenses = new Button();
            txtSearchExpense = new TextBox();
            pnlTopCategory = new Panel();
            pnlCategoryIcon = new Panel();
            lblCategoryIcon = new Label();
            lblTopCategoryTitle = new Label();
            lblTopCategoryValue = new Label();
            pnlTransactionsCount = new Panel();
            pnlTransactionsIcon = new Panel();
            lblTransactionsIcon = new Label();
            lblTransactionsValue = new Label();
            lblTransactionsTitle = new Label();
            pnlTotalExpenses = new Panel();
            pnlTotalIcon = new Panel();
            label4 = new Label();
            label7 = new Label();
            lblTotalTitle = new Label();
            cmbMonth = new ComboBox();
            lblSub = new Label();
            lblPageTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlProfile.SuspendLayout();
            pnlLogo.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlExpensesTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).BeginInit();
            pnlTopCategory.SuspendLayout();
            pnlCategoryIcon.SuspendLayout();
            pnlTransactionsCount.SuspendLayout();
            pnlTransactionsIcon.SuspendLayout();
            pnlTotalExpenses.SuspendLayout();
            pnlTotalIcon.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(25, 42, 90);
            pnlSidebar.BorderStyle = BorderStyle.Fixed3D;
            pnlSidebar.Controls.Add(label2);
            pnlSidebar.Controls.Add(lblProfileName);
            pnlSidebar.Controls.Add(pnlProfile);
            pnlSidebar.Controls.Add(pnlSeparator);
            pnlSidebar.Controls.Add(lblR);
            pnlSidebar.Controls.Add(btnReports);
            pnlSidebar.Controls.Add(lblB);
            pnlSidebar.Controls.Add(btnBudget);
            pnlSidebar.Controls.Add(lblE);
            pnlSidebar.Controls.Add(btnExpenses);
            pnlSidebar.Controls.Add(lblI);
            pnlSidebar.Controls.Add(btnIncome);
            pnlSidebar.Controls.Add(lblD);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(lblMainMenu);
            pnlSidebar.Controls.Add(lblSubtitle);
            pnlSidebar.Controls.Add(pnlLogo);
            pnlSidebar.Controls.Add(lblLogo);
            pnlSidebar.Location = new Point(3, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(254, 749);
            pnlSidebar.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(170, 182, 211);
            label2.Location = new Point(61, 701);
            label2.Name = "label2";
            label2.Size = new Size(108, 17);
            label2.TabIndex = 14;
            label2.Text = "Personal Account";
            // 
            // lblProfileName
            // 
            lblProfileName.AutoSize = true;
            lblProfileName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileName.ForeColor = SystemColors.ControlLightLight;
            lblProfileName.Location = new Point(65, 681);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(99, 20);
            lblProfileName.TabIndex = 1;
            lblProfileName.Text = "Alex Morgan";
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.LightCyan;
            pnlProfile.Controls.Add(lblProfileInitial);
            pnlProfile.Location = new Point(23, 678);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(36, 40);
            pnlProfile.TabIndex = 1;
            pnlProfile.Paint += pnlProfile_Paint;
            // 
            // lblProfileInitial
            // 
            lblProfileInitial.AutoSize = true;
            lblProfileInitial.BackColor = Color.Transparent;
            lblProfileInitial.Dock = DockStyle.Fill;
            lblProfileInitial.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfileInitial.ForeColor = SystemColors.HotTrack;
            lblProfileInitial.Location = new Point(0, 0);
            lblProfileInitial.Name = "lblProfileInitial";
            lblProfileInitial.Size = new Size(30, 31);
            lblProfileInitial.TabIndex = 0;
            lblProfileInitial.Text = "A";
            lblProfileInitial.TextAlign = ContentAlignment.MiddleCenter;
            lblProfileInitial.Click += lblProfileInitial_Click;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(65, 79, 112);
            pnlSeparator.Location = new Point(18, 657);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(205, 1);
            pnlSeparator.TabIndex = 13;
            // 
            // lblR
            // 
            lblR.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblR.ForeColor = Color.Gainsboro;
            lblR.Location = new Point(25, 340);
            lblR.Name = "lblR";
            lblR.Size = new Size(30, 32);
            lblR.TabIndex = 12;
            lblR.Text = "R";
            lblR.TextAlign = ContentAlignment.MiddleCenter;
            lblR.Click += lblR_Click;
            // 
            // btnReports
            // 
            btnReports.Cursor = Cursors.Hand;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 61, 112);
            btnReports.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 61, 112);
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReports.ForeColor = Color.Gainsboro;
            btnReports.Location = new Point(13, 335);
            btnReports.Name = "btnReports";
            btnReports.Padding = new Padding(12, 0, 12, 0);
            btnReports.Size = new Size(193, 43);
            btnReports.TabIndex = 11;
            btnReports.Text = "Reports";
            btnReports.UseVisualStyleBackColor = false;
            // 
            // lblB
            // 
            lblB.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblB.ForeColor = Color.Gainsboro;
            lblB.Location = new Point(25, 293);
            lblB.Name = "lblB";
            lblB.Size = new Size(30, 30);
            lblB.TabIndex = 10;
            lblB.Text = "B";
            lblB.TextAlign = ContentAlignment.MiddleCenter;
            lblB.Click += lblB_Click;
            // 
            // btnBudget
            // 
            btnBudget.Cursor = Cursors.Hand;
            btnBudget.FlatAppearance.BorderSize = 0;
            btnBudget.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 61, 112);
            btnBudget.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 61, 112);
            btnBudget.FlatStyle = FlatStyle.Flat;
            btnBudget.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBudget.ForeColor = Color.Gainsboro;
            btnBudget.Location = new Point(15, 287);
            btnBudget.Name = "btnBudget";
            btnBudget.Padding = new Padding(12, 0, 12, 0);
            btnBudget.Size = new Size(191, 42);
            btnBudget.TabIndex = 9;
            btnBudget.Text = "Budget";
            btnBudget.UseVisualStyleBackColor = false;
            btnBudget.Click += btnBudget_Click;
            // 
            // lblE
            // 
            lblE.BackColor = Color.FromArgb(48, 69, 116);
            lblE.Cursor = Cursors.Hand;
            lblE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblE.ForeColor = Color.Gainsboro;
            lblE.Location = new Point(25, 245);
            lblE.Name = "lblE";
            lblE.Size = new Size(30, 30);
            lblE.TabIndex = 8;
            lblE.Text = "E";
            lblE.TextAlign = ContentAlignment.MiddleCenter;
            lblE.Click += lblE_Click;
            // 
            // btnExpenses
            // 
            btnExpenses.BackColor = Color.FromArgb(48, 69, 116);
            btnExpenses.Cursor = Cursors.Hand;
            btnExpenses.FlatAppearance.BorderSize = 0;
            btnExpenses.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 110, 220);
            btnExpenses.FlatAppearance.MouseOverBackColor = Color.FromArgb(65, 140, 245);
            btnExpenses.FlatStyle = FlatStyle.Flat;
            btnExpenses.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExpenses.ForeColor = Color.Gainsboro;
            btnExpenses.Location = new Point(13, 239);
            btnExpenses.Name = "btnExpenses";
            btnExpenses.Padding = new Padding(12, 0, 12, 0);
            btnExpenses.Size = new Size(190, 42);
            btnExpenses.TabIndex = 7;
            btnExpenses.Text = "Expenses";
            btnExpenses.UseVisualStyleBackColor = false;
            // 
            // lblI
            // 
            lblI.BackColor = Color.FromArgb(25, 42, 90);
            lblI.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblI.ForeColor = Color.Gainsboro;
            lblI.Location = new Point(25, 195);
            lblI.Name = "lblI";
            lblI.Size = new Size(30, 30);
            lblI.TabIndex = 6;
            lblI.Text = "I";
            lblI.TextAlign = ContentAlignment.MiddleCenter;
            lblI.Click += lblI_Click;
            // 
            // btnIncome
            // 
            btnIncome.Cursor = Cursors.Hand;
            btnIncome.FlatAppearance.BorderSize = 0;
            btnIncome.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 61, 112);
            btnIncome.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 61, 112);
            btnIncome.FlatStyle = FlatStyle.Flat;
            btnIncome.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncome.ForeColor = Color.Gainsboro;
            btnIncome.Location = new Point(14, 188);
            btnIncome.Name = "btnIncome";
            btnIncome.Padding = new Padding(12, 0, 12, 0);
            btnIncome.Size = new Size(189, 45);
            btnIncome.TabIndex = 5;
            btnIncome.Text = "Income";
            btnIncome.UseVisualStyleBackColor = false;
            // 
            // lblD
            // 
            lblD.BackColor = Color.FromArgb(25, 42, 90);
            lblD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblD.ForeColor = Color.Gainsboro;
            lblD.Location = new Point(25, 142);
            lblD.Name = "lblD";
            lblD.Size = new Size(30, 30);
            lblD.TabIndex = 4;
            lblD.Text = "D";
            lblD.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(25, 42, 90);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(41, 61, 112);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(41, 61, 112);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Gainsboro;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(15, 132);
            button1.Name = "button1";
            button1.Padding = new Padding(12, 0, 12, 0);
            button1.Size = new Size(188, 50);
            button1.TabIndex = 3;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblMainMenu
            // 
            lblMainMenu.BackColor = Color.Transparent;
            lblMainMenu.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMainMenu.ForeColor = Color.FromArgb(132, 147, 181);
            lblMainMenu.Location = new Point(18, 103);
            lblMainMenu.Name = "lblMainMenu";
            lblMainMenu.Size = new Size(104, 27);
            lblMainMenu.TabIndex = 2;
            lblMainMenu.Text = "MAIN MENU";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(170, 182, 211);
            lblSubtitle.Location = new Point(68, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(127, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "PERSONAL FINANCE";
            lblSubtitle.Click += lblSubtitle_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.FromArgb(52, 127, 234);
            pnlLogo.BorderStyle = BorderStyle.FixedSingle;
            pnlLogo.Controls.Add(label1);
            pnlLogo.Location = new Point(18, 26);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(45, 45);
            pnlLogo.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 43);
            label1.TabIndex = 0;
            label1.Text = "M";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(65, 26);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(130, 31);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "MyFinance";
            lblLogo.Click += lblLogo_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(pnlExpensesTable);
            pnlMain.Controls.Add(btnAddExpenses);
            pnlMain.Controls.Add(txtSearchExpense);
            pnlMain.Controls.Add(pnlTopCategory);
            pnlMain.Controls.Add(pnlTransactionsCount);
            pnlMain.Controls.Add(pnlTotalExpenses);
            pnlMain.Controls.Add(cmbMonth);
            pnlMain.Controls.Add(lblSub);
            pnlMain.Controls.Add(lblPageTitle);
            pnlMain.Location = new Point(263, 2);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(987, 739);
            pnlMain.TabIndex = 1;
            // 
            // pnlExpensesTable
            // 
            pnlExpensesTable.BackColor = Color.White;
            pnlExpensesTable.BorderStyle = BorderStyle.FixedSingle;
            pnlExpensesTable.Controls.Add(lblEmptyDescription);
            pnlExpensesTable.Controls.Add(label5);
            pnlExpensesTable.Controls.Add(lblEmptyIcon);
            pnlExpensesTable.Controls.Add(dgvExpenses);
            pnlExpensesTable.Controls.Add(label3);
            pnlExpensesTable.Location = new Point(29, 310);
            pnlExpensesTable.Name = "pnlExpensesTable";
            pnlExpensesTable.Size = new Size(907, 410);
            pnlExpensesTable.TabIndex = 17;
            pnlExpensesTable.Paint += pnlExpensesTable_Paint;
            // 
            // lblEmptyDescription
            // 
            lblEmptyDescription.AutoSize = true;
            lblEmptyDescription.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmptyDescription.ForeColor = Color.FromArgb(130, 144, 162);
            lblEmptyDescription.Location = new Point(305, 329);
            lblEmptyDescription.Name = "lblEmptyDescription";
            lblEmptyDescription.Size = new Size(335, 20);
            lblEmptyDescription.TabIndex = 20;
            lblEmptyDescription.Text = "Select\"Add Expense\" to record your first expense.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(90, 105, 125);
            label5.Location = new Point(369, 290);
            label5.Name = "label5";
            label5.Size = new Size(195, 23);
            label5.TabIndex = 19;
            label5.Text = "No expenses added yet";
            // 
            // lblEmptyIcon
            // 
            lblEmptyIcon.BackColor = Color.Transparent;
            lblEmptyIcon.Font = new Font("Segoe UI", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmptyIcon.ForeColor = Color.FromArgb(190, 202, 220);
            lblEmptyIcon.Location = new Point(424, 221);
            lblEmptyIcon.Name = "lblEmptyIcon";
            lblEmptyIcon.Size = new Size(45, 58);
            lblEmptyIcon.TabIndex = 18;
            lblEmptyIcon.Text = "+";
            lblEmptyIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblEmptyIcon.Click += lblEmptyIcon_Click;
            // 
            // dgvExpenses
            // 
            dgvExpenses.AllowUserToAddRows = false;
            dgvExpenses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 250, 252);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(32, 43, 60);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(32, 43, 60);
            dgvExpenses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExpenses.BackgroundColor = Color.White;
            dgvExpenses.BorderStyle = BorderStyle.None;
            dgvExpenses.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvExpenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 247, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(90, 105, 125);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvExpenses.ColumnHeadersHeight = 50;
            dgvExpenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvExpenses.Columns.AddRange(new DataGridViewColumn[] { colExpenseName, colCategory, colDate, colPaymentMethod, colAmount });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(32, 43, 60);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(230, 240, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(32, 43, 60);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvExpenses.DefaultCellStyle = dataGridViewCellStyle3;
            dgvExpenses.EnableHeadersVisualStyles = false;
            dgvExpenses.GridColor = Color.FromArgb(235, 238, 243);
            dgvExpenses.Location = new Point(20, 41);
            dgvExpenses.MultiSelect = false;
            dgvExpenses.Name = "dgvExpenses";
            dgvExpenses.ReadOnly = true;
            dgvExpenses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvExpenses.RowHeadersVisible = false;
            dgvExpenses.RowHeadersWidth = 51;
            dgvExpenses.RowTemplate.Height = 50;
            dgvExpenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExpenses.Size = new Size(862, 328);
            dgvExpenses.TabIndex = 16;
            // 
            // colExpenseName
            // 
            colExpenseName.HeaderText = "Expense";
            colExpenseName.MinimumWidth = 6;
            colExpenseName.Name = "colExpenseName";
            colExpenseName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            colPaymentMethod.HeaderText = "Payment Method";
            colPaymentMethod.MinimumWidth = 6;
            colPaymentMethod.Name = "colPaymentMethod";
            colPaymentMethod.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.HeaderText = "Amount";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(32, 43, 60);
            label3.Location = new Point(18, 13);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 16;
            label3.Text = "Expense Transactions";
            label3.Click += label3_Click;
            // 
            // btnAddExpenses
            // 
            btnAddExpenses.BackColor = Color.FromArgb(52, 127, 234);
            btnAddExpenses.Cursor = Cursors.Hand;
            btnAddExpenses.FlatAppearance.BorderSize = 0;
            btnAddExpenses.FlatStyle = FlatStyle.Flat;
            btnAddExpenses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddExpenses.ForeColor = Color.White;
            btnAddExpenses.Location = new Point(741, 236);
            btnAddExpenses.Name = "btnAddExpenses";
            btnAddExpenses.Size = new Size(195, 38);
            btnAddExpenses.TabIndex = 14;
            btnAddExpenses.Text = "+ Add Expense";
            btnAddExpenses.UseVisualStyleBackColor = false;
            // 
            // txtSearchExpense
            // 
            txtSearchExpense.BackColor = Color.White;
            txtSearchExpense.BorderStyle = BorderStyle.FixedSingle;
            txtSearchExpense.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchExpense.ForeColor = Color.FromArgb(32, 43, 60);
            txtSearchExpense.Location = new Point(29, 241);
            txtSearchExpense.Multiline = true;
            txtSearchExpense.Name = "txtSearchExpense";
            txtSearchExpense.PlaceholderText = "Search expenses";
            txtSearchExpense.Size = new Size(260, 40);
            txtSearchExpense.TabIndex = 13;
            // 
            // pnlTopCategory
            // 
            pnlTopCategory.BackColor = Color.White;
            pnlTopCategory.BorderStyle = BorderStyle.FixedSingle;
            pnlTopCategory.Controls.Add(pnlCategoryIcon);
            pnlTopCategory.Controls.Add(lblTopCategoryTitle);
            pnlTopCategory.Controls.Add(lblTopCategoryValue);
            pnlTopCategory.Location = new Point(645, 105);
            pnlTopCategory.Name = "pnlTopCategory";
            pnlTopCategory.Size = new Size(291, 105);
            pnlTopCategory.TabIndex = 7;
            // 
            // pnlCategoryIcon
            // 
            pnlCategoryIcon.BackColor = Color.FromArgb(240, 245, 255);
            pnlCategoryIcon.Controls.Add(lblCategoryIcon);
            pnlCategoryIcon.Location = new Point(226, 15);
            pnlCategoryIcon.Name = "pnlCategoryIcon";
            pnlCategoryIcon.Size = new Size(40, 40);
            pnlCategoryIcon.TabIndex = 12;
            // 
            // lblCategoryIcon
            // 
            lblCategoryIcon.BackColor = Color.Transparent;
            lblCategoryIcon.Dock = DockStyle.Fill;
            lblCategoryIcon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoryIcon.ForeColor = Color.FromArgb(52, 127, 234);
            lblCategoryIcon.Location = new Point(0, 0);
            lblCategoryIcon.Name = "lblCategoryIcon";
            lblCategoryIcon.Size = new Size(40, 40);
            lblCategoryIcon.TabIndex = 9;
            lblCategoryIcon.Text = "C";
            lblCategoryIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTopCategoryTitle
            // 
            lblTopCategoryTitle.AutoSize = true;
            lblTopCategoryTitle.BackColor = Color.Transparent;
            lblTopCategoryTitle.ForeColor = Color.FromArgb(130, 144, 162);
            lblTopCategoryTitle.Location = new Point(17, 22);
            lblTopCategoryTitle.Name = "lblTopCategoryTitle";
            lblTopCategoryTitle.Size = new Size(165, 20);
            lblTopCategoryTitle.TabIndex = 3;
            lblTopCategoryTitle.Text = "Top Spending Category";
            lblTopCategoryTitle.Click += lblTopCategoryTitle_Click;
            // 
            // lblTopCategoryValue
            // 
            lblTopCategoryValue.AutoSize = true;
            lblTopCategoryValue.BackColor = Color.Transparent;
            lblTopCategoryValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopCategoryValue.ForeColor = Color.FromArgb(32, 43, 60);
            lblTopCategoryValue.Location = new Point(15, 50);
            lblTopCategoryValue.Name = "lblTopCategoryValue";
            lblTopCategoryValue.Size = new Size(34, 46);
            lblTopCategoryValue.TabIndex = 8;
            lblTopCategoryValue.Text = "-";
            // 
            // pnlTransactionsCount
            // 
            pnlTransactionsCount.BackColor = Color.White;
            pnlTransactionsCount.BorderStyle = BorderStyle.FixedSingle;
            pnlTransactionsCount.Controls.Add(pnlTransactionsIcon);
            pnlTransactionsCount.Controls.Add(lblTransactionsValue);
            pnlTransactionsCount.Controls.Add(lblTransactionsTitle);
            pnlTransactionsCount.Location = new Point(335, 105);
            pnlTransactionsCount.Name = "pnlTransactionsCount";
            pnlTransactionsCount.Size = new Size(288, 105);
            pnlTransactionsCount.TabIndex = 0;
            // 
            // pnlTransactionsIcon
            // 
            pnlTransactionsIcon.BackColor = Color.FromArgb(240, 245, 255);
            pnlTransactionsIcon.Controls.Add(lblTransactionsIcon);
            pnlTransactionsIcon.Location = new Point(231, 15);
            pnlTransactionsIcon.Name = "pnlTransactionsIcon";
            pnlTransactionsIcon.Size = new Size(40, 40);
            pnlTransactionsIcon.TabIndex = 0;
            // 
            // lblTransactionsIcon
            // 
            lblTransactionsIcon.BackColor = Color.Transparent;
            lblTransactionsIcon.Dock = DockStyle.Fill;
            lblTransactionsIcon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsIcon.ForeColor = Color.FromArgb(52, 127, 234);
            lblTransactionsIcon.Location = new Point(0, 0);
            lblTransactionsIcon.Name = "lblTransactionsIcon";
            lblTransactionsIcon.Size = new Size(40, 40);
            lblTransactionsIcon.TabIndex = 2;
            lblTransactionsIcon.Text = "T";
            lblTransactionsIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblTransactionsIcon.Click += lblTransactionsIcon_Click;
            // 
            // lblTransactionsValue
            // 
            lblTransactionsValue.AutoSize = true;
            lblTransactionsValue.BackColor = Color.Transparent;
            lblTransactionsValue.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransactionsValue.ForeColor = Color.FromArgb(32, 43, 60);
            lblTransactionsValue.Location = new Point(15, 50);
            lblTransactionsValue.Name = "lblTransactionsValue";
            lblTransactionsValue.Size = new Size(40, 46);
            lblTransactionsValue.TabIndex = 5;
            lblTransactionsValue.Text = "0";
            // 
            // lblTransactionsTitle
            // 
            lblTransactionsTitle.AutoSize = true;
            lblTransactionsTitle.BackColor = Color.Transparent;
            lblTransactionsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTransactionsTitle.ForeColor = Color.FromArgb(130, 144, 162);
            lblTransactionsTitle.Location = new Point(15, 22);
            lblTransactionsTitle.Name = "lblTransactionsTitle";
            lblTransactionsTitle.Size = new Size(148, 20);
            lblTransactionsTitle.TabIndex = 0;
            lblTransactionsTitle.Text = "Expense Transactions";
            lblTransactionsTitle.Click += lblTransactionsTitle_Click;
            // 
            // pnlTotalExpenses
            // 
            pnlTotalExpenses.BackColor = Color.White;
            pnlTotalExpenses.BorderStyle = BorderStyle.FixedSingle;
            pnlTotalExpenses.Controls.Add(pnlTotalIcon);
            pnlTotalExpenses.Controls.Add(label7);
            pnlTotalExpenses.Controls.Add(lblTotalTitle);
            pnlTotalExpenses.Location = new Point(29, 105);
            pnlTotalExpenses.Name = "pnlTotalExpenses";
            pnlTotalExpenses.Size = new Size(285, 105);
            pnlTotalExpenses.TabIndex = 3;
            // 
            // pnlTotalIcon
            // 
            pnlTotalIcon.BackColor = Color.FromArgb(240, 245, 255);
            pnlTotalIcon.Controls.Add(label4);
            pnlTotalIcon.Location = new Point(225, 15);
            pnlTotalIcon.Name = "pnlTotalIcon";
            pnlTotalIcon.Size = new Size(40, 40);
            pnlTotalIcon.TabIndex = 5;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(52, 127, 234);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 40);
            label4.TabIndex = 7;
            label4.Text = "E";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(32, 43, 60);
            label7.Location = new Point(18, 49);
            label7.Name = "label7";
            label7.Size = new Size(161, 46);
            label7.TabIndex = 4;
            label7.Text = "0.00 EGP";
            // 
            // lblTotalTitle
            // 
            lblTotalTitle.BackColor = Color.Transparent;
            lblTotalTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalTitle.ForeColor = Color.FromArgb(130, 144, 162);
            lblTotalTitle.Location = new Point(18, 22);
            lblTotalTitle.Name = "lblTotalTitle";
            lblTotalTitle.Size = new Size(148, 29);
            lblTotalTitle.TabIndex = 0;
            lblTotalTitle.Text = "Total Expenses ";
            // 
            // cmbMonth
            // 
            cmbMonth.BackColor = Color.White;
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FlatStyle = FlatStyle.Flat;
            cmbMonth.ForeColor = Color.FromArgb(32, 43, 60);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Items.AddRange(new object[] { "November 2026", "October 2026 ", "September 2026" });
            cmbMonth.Location = new Point(790, 30);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(160, 28);
            cmbMonth.TabIndex = 2;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.BackColor = Color.Transparent;
            lblSub.ForeColor = Color.FromArgb(130, 144, 162);
            lblSub.Location = new Point(29, 63);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(259, 20);
            lblSub.TabIndex = 1;
            lblSub.Text = "Keep track of where your money goes";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.BackColor = Color.Transparent;
            lblPageTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(32, 43, 60);
            lblPageTitle.Location = new Point(20, 13);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(179, 50);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Expenses";
            // 
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1262, 753);
            Controls.Add(pnlMain);
            Controls.Add(pnlSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ExpensesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expenses";
            Load += ExpensesForm_Load;
            pnlSidebar.ResumeLayout(false);
            pnlSidebar.PerformLayout();
            pnlProfile.ResumeLayout(false);
            pnlProfile.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlExpensesTable.ResumeLayout(false);
            pnlExpensesTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExpenses).EndInit();
            pnlTopCategory.ResumeLayout(false);
            pnlTopCategory.PerformLayout();
            pnlCategoryIcon.ResumeLayout(false);
            pnlTransactionsCount.ResumeLayout(false);
            pnlTransactionsCount.PerformLayout();
            pnlTransactionsIcon.ResumeLayout(false);
            pnlTotalExpenses.ResumeLayout(false);
            pnlTotalExpenses.PerformLayout();
            pnlTotalIcon.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblLogo;
        private Panel pnlLogo;
        private Label label1;
        private Label lblSubtitle;
        private Label lblMainMenu;
        private Button button1;
        private Label lblD;
        private Button btnIncome;
        private Label lblI;
        private Button btnExpenses;
        private Label lblE;
        private Button btnBudget;
        private Label lblB;
        private Button btnReports;
        private Label lblR;
        private Panel pnlSeparator;
        private Panel pnlProfile;
        private Label lblProfileInitial;
        private Label lblProfileName;
        private Label label2;
        private Panel pnlMain;
        private Label lblPageTitle;
        private Label lblSub;
        private ComboBox cmbMonth;
        private Panel pnlTotalExpenses;
        private Label lblTotalTitle;
        private Panel pnlTransactionsCount;
        private Label lblTopCategoryTitle;
        private Label lblTransactionsIcon;
        private Label lblTransactionsValue;
        private Label lblTransactionsTitle;
        private Label label7;
        private Panel pnlTransactionsIcon;
        private Panel pnlTotalIcon;
        private Label label4;
        private Panel pnlTopCategory;
        private Label lblCategoryIcon;
        private Label lblTopCategoryValue;
        private Panel pnlCategoryIcon;
        private TextBox txtSearchExpense;
        private Button btnAddExpenses;
        private Label label3;
        private Panel pnlExpensesTable;
        private DataGridView dgvExpenses;
        private DataGridViewTextBoxColumn colExpenseName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colAmount;
        private Label lblEmptyIcon;
        private Label lblEmptyDescription;
        private Label label5;
    }
}
