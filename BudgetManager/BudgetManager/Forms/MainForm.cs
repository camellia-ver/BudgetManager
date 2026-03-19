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
            lvTransactions.Columns.Add("날짜", 100);
            lvTransactions.Columns.Add("구분", 60);
            lvTransactions.Columns.Add("금액", 100);
            lvTransactions.Columns.Add("카테고리", 100);
            lvTransactions.Columns.Add("설명", 200);

            lvTransactions.View = View.Details;

            InitializeComponent();
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
            var form = new TransactionForm();
            form.ShowDialog();
            LoadData();
        }
    }
}
