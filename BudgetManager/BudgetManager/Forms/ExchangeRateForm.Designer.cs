namespace BudgetManager.Forms
{
    partial class ExchangeRateForm
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
            lblResult = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            txtAmount = new TextBox();
            cmbCurrency = new ComboBox();
            btnConvert = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblResult, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(btnConvert, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(445, 260);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("맑은 고딕", 16F);
            lblResult.Location = new Point(3, 188);
            lblResult.Name = "lblResult";
            lblResult.RightToLeft = RightToLeft.No;
            lblResult.Size = new Size(86, 37);
            lblResult.TabIndex = 3;
            lblResult.Text = "결과: ";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 0;
            label1.Text = "환율 변환";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(txtAmount, 1, 0);
            tableLayoutPanel2.Controls.Add(cmbCurrency, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(439, 63);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 16F);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 37);
            label2.TabIndex = 1;
            label2.Text = "금액:";
            // 
            // txtAmount
            // 
            txtAmount.Dock = DockStyle.Fill;
            txtAmount.Font = new Font("맑은 고딕", 14F);
            txtAmount.Location = new Point(149, 3);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(140, 39);
            txtAmount.TabIndex = 2;
            // 
            // cmbCurrency
            // 
            cmbCurrency.Dock = DockStyle.Fill;
            cmbCurrency.Font = new Font("맑은 고딕", 14F);
            cmbCurrency.FormattingEnabled = true;
            cmbCurrency.Location = new Point(295, 3);
            cmbCurrency.Name = "cmbCurrency";
            cmbCurrency.Size = new Size(141, 39);
            cmbCurrency.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Dock = DockStyle.Fill;
            btnConvert.Font = new Font("맑은 고딕", 14F);
            btnConvert.Location = new Point(3, 122);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(439, 63);
            btnConvert.TabIndex = 2;
            btnConvert.Text = "변환";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // ExchangeRateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 260);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            Name = "ExchangeRateForm";
            Text = "ExchangeRateForm";
            Load += ExchangeRateForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private TextBox txtAmount;
        private ComboBox cmbCurrency;
        private Button btnConvert;
        private Label lblResult;
    }
}