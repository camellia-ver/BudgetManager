using BudgetManager.Services;
using BudgetManager.Models;
using BudgetManager.Forms;

namespace BudgetManager
{
    public partial class MainForm : Form
    {
        private readonly DatabaseService _databaseService = new DatabaseService();

        public MainForm()
        {
            InitializeComponent();

            lvTransactions.Columns.Add("날짜", 100);
            lvTransactions.Columns.Add("구분", 60);
            lvTransactions.Columns.Add("금액", 100);
            lvTransactions.Columns.Add("카테고리", 100);
            lvTransactions.Columns.Add("설명", 200);

            lvTransactions.View = View.Details;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            LoadBalance();
            LoadMonthlySummary();
            LoadTransactions();
        }

        private void LoadBalance()
        {
            lblBalance.Text = $"₩ {_databaseService.GetBalance():N0}";
        }

        private void LoadMonthlySummary()
        {
            DateTime date = dtpMonth.Value;
            (decimal income, decimal expense) = _databaseService.GetMonthlyTotal(date);
            lblIncome.Text = $"이번 달 수입: ₩ {income:N0}";
            lblExpense.Text = $"이번 달 지출: ₩ {expense:N0}";
        }

        private void LoadTransactions()
        {
            lvTransactions.Items.Clear();

            DateTime startDate = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            List<Transaction> transactions = _databaseService.GetTransactions(startDate, endDate);
            foreach (Transaction t in transactions)
            {
                ListViewItem item = new ListViewItem(t.Date.ToString("yyyy-MM-dd"));
                item.Tag = t;
                item.SubItems.Add(t.Type == TransactionType.Income ? "수입" : "지출");
                item.SubItems.Add($"₩ {t.Amount:N0}");
                item.SubItems.Add(t.Category);
                item.SubItems.Add(t.Description);
                lvTransactions.Items.Add(item);
            }
        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var form = new TransactionForm(_databaseService);
            form.ShowDialog();
            LoadData();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            var form = new StatisticsForm(_databaseService);
            form.ShowDialog();
        }

        private void lvTransactions_DoubleClick(object sender, EventArgs e)
        {
            if (lvTransactions.SelectedItems.Count == 0) return;

            var selected = lvTransactions.SelectedItems[0];
            var transcation = (Transaction)selected.Tag;

            var form = new TransactionForm(_databaseService, transcation);
            form.ShowDialog();
            LoadData();
        }

        private void lvTransactions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Delete) return;
            if (lvTransactions.SelectedItems.Count == 0) return;

            var result = MessageBox.Show("정말 삭제할까요?", "삭제 확인",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            var selected = lvTransactions.SelectedItems[0];
            var transcation = (Transaction)selected.Tag;

            _databaseService.DeleteTransaction(transcation.Id);

            LoadData();
        }

        private void mnuExchangeRate_Click(object sender, EventArgs e)
        {
            var form = new ExchangeRateForm();
            form.ShowDialog();
        }
    }
}
