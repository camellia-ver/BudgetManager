namespace BudgetManager
{
    partial class MainForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            lblBalance = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblExpense = new Label();
            lblIncome = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnStatistics = new Button();
            btnAddTransaction = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            lvTransactions = new ListView();
            dtpMonth = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(lblBalance, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(794, 84);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 129);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 38);
            label2.TabIndex = 0;
            label2.Text = "💰 현재 잔고";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("맑은 고딕", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblBalance.Location = new Point(3, 42);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(149, 31);
            lblBalance.TabIndex = 1;
            lblBalance.Text = "₩ 1,250,000 ";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(lblExpense, 0, 1);
            tableLayoutPanel3.Controls.Add(lblIncome, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 93);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(794, 84);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblExpense
            // 
            lblExpense.AutoSize = true;
            lblExpense.Font = new Font("맑은 고딕", 12F);
            lblExpense.Location = new Point(3, 42);
            lblExpense.Name = "lblExpense";
            lblExpense.Size = new Size(250, 28);
            lblExpense.TabIndex = 1;
            lblExpense.Text = "이번 달 지출: ₩ 250,000   ";
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Font = new Font("맑은 고딕", 12F);
            lblIncome.Location = new Point(3, 0);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(271, 28);
            lblIncome.TabIndex = 0;
            lblIncome.Text = " 이번 달 수입: ₩ 500,000     ";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnStatistics, 1, 0);
            tableLayoutPanel4.Controls.Add(btnAddTransaction, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 408);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(794, 39);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // btnStatistics
            // 
            btnStatistics.Dock = DockStyle.Fill;
            btnStatistics.Location = new Point(400, 3);
            btnStatistics.Name = "btnStatistics";
            btnStatistics.Size = new Size(391, 33);
            btnStatistics.TabIndex = 1;
            btnStatistics.Text = "📊 통계";
            btnStatistics.UseVisualStyleBackColor = true;
            btnStatistics.Click += btnStatistics_Click;
            // 
            // btnAddTransaction
            // 
            btnAddTransaction.Dock = DockStyle.Fill;
            btnAddTransaction.Location = new Point(3, 3);
            btnAddTransaction.Name = "btnAddTransaction";
            btnAddTransaction.Size = new Size(391, 33);
            btnAddTransaction.TabIndex = 0;
            btnAddTransaction.Text = "+ 거래 추가";
            btnAddTransaction.UseVisualStyleBackColor = true;
            btnAddTransaction.Click += btnAddTransaction_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(lvTransactions, 0, 1);
            tableLayoutPanel5.Controls.Add(dtpMonth, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 183);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(794, 219);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // lvTransactions
            // 
            lvTransactions.Dock = DockStyle.Fill;
            lvTransactions.Location = new Point(3, 53);
            lvTransactions.Name = "lvTransactions";
            lvTransactions.Size = new Size(788, 163);
            lvTransactions.TabIndex = 0;
            lvTransactions.UseCompatibleStateImageBehavior = false;
            lvTransactions.DoubleClick += lvTransactions_DoubleClick;
            lvTransactions.KeyDown += lvTransactions_KeyDown;
            // 
            // dtpMonth
            // 
            dtpMonth.CustomFormat = "yyyy-MM";
            dtpMonth.Dock = DockStyle.Fill;
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.Location = new Point(3, 3);
            dtpMonth.Name = "dtpMonth";
            dtpMonth.Size = new Size(788, 27);
            dtpMonth.TabIndex = 1;
            dtpMonth.ValueChanged += dtpMonth_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "Budget Manager";
            Load += MainForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label lblBalance;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblExpense;
        private Label lblIncome;
        private TableLayoutPanel tableLayoutPanel4;
        private Button btnStatistics;
        private Button btnAddTransaction;
        private TableLayoutPanel tableLayoutPanel5;
        private ListView lvTransactions;
        private DateTimePicker dtpMonth;
    }
}
