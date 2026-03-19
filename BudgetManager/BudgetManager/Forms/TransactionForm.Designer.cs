namespace BudgetManager.Forms
{
    partial class TransactionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            label6 = new Label();
            txtDescription = new TextBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            label5 = new Label();
            txtAmount = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            dtpDate = new DateTimePicker();
            tableLayoutPanel3 = new TableLayoutPanel();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            rbExpense = new RadioButton();
            rbIncome = new RadioButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            label4 = new Label();
            cmbCategory = new ComboBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel7.Controls.Add(label6, 0, 0);
            tableLayoutPanel7.Controls.Add(txtDescription, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 323);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(794, 58);
            tableLayoutPanel7.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 16F);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 37);
            label6.TabIndex = 3;
            label6.Text = "설명:";
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("맑은 고딕", 12F);
            txtDescription.Location = new Point(161, 3);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(630, 34);
            txtDescription.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel6.Controls.Add(label5, 0, 0);
            tableLayoutPanel6.Controls.Add(txtAmount, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 259);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(794, 58);
            tableLayoutPanel6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 16F);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 37);
            label5.TabIndex = 3;
            label5.Text = "금액:";
            // 
            // txtAmount
            // 
            txtAmount.Dock = DockStyle.Fill;
            txtAmount.Font = new Font("맑은 고딕", 12F);
            txtAmount.Location = new Point(161, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(630, 34);
            txtAmount.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "거래 추가";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(dtpDate, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 67);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 58);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 37);
            label2.TabIndex = 1;
            label2.Text = "날짜: ";
            // 
            // dtpDate
            // 
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Location = new Point(161, 3);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(630, 27);
            dtpDate.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 131);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(794, 58);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 16F);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 37);
            label3.TabIndex = 2;
            label3.Text = "구분:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(rbExpense, 1, 0);
            tableLayoutPanel4.Controls.Add(rbIncome, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(161, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(630, 52);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // rbExpense
            // 
            rbExpense.AutoSize = true;
            rbExpense.Dock = DockStyle.Fill;
            rbExpense.Font = new Font("맑은 고딕", 12F);
            rbExpense.Location = new Point(318, 3);
            rbExpense.Name = "rbExpense";
            rbExpense.Size = new Size(309, 46);
            rbExpense.TabIndex = 1;
            rbExpense.TabStop = true;
            rbExpense.Text = "지출";
            rbExpense.UseVisualStyleBackColor = true;
            rbExpense.CheckedChanged += rbExpense_CheckedChanged;
            // 
            // rbIncome
            // 
            rbIncome.AutoSize = true;
            rbIncome.Dock = DockStyle.Fill;
            rbIncome.Font = new Font("맑은 고딕", 12F);
            rbIncome.Location = new Point(3, 3);
            rbIncome.Name = "rbIncome";
            rbIncome.Size = new Size(309, 46);
            rbIncome.TabIndex = 0;
            rbIncome.TabStop = true;
            rbIncome.Text = "수입";
            rbIncome.UseVisualStyleBackColor = true;
            rbIncome.CheckedChanged += rbIncome_CheckedChanged;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.Controls.Add(label4, 0, 0);
            tableLayoutPanel5.Controls.Add(cmbCategory, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 195);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(794, 58);
            tableLayoutPanel5.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 16F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(131, 37);
            label4.TabIndex = 3;
            label4.Text = "카테고리:";
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(161, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(630, 28);
            cmbCategory.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel8.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 387);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(794, 60);
            tableLayoutPanel8.TabIndex = 6;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Font = new Font("맑은 고딕", 12F);
            btnCancel.Location = new Point(400, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(391, 54);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Font = new Font("맑은 고딕", 12F);
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(391, 54);
            btnSave.TabIndex = 0;
            btnSave.Text = "저장";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // TransactionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionForm";
            Text = "TransactionForm";
            Load += TransactionForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private DateTimePicker dtpDate;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton rbExpense;
        private RadioButton rbIncome;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label6;
        private TextBox txtDescription;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label5;
        private TextBox txtAmount;
        private ComboBox cmbCategory;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btnCancel;
        private Button btnSave;
    }
}