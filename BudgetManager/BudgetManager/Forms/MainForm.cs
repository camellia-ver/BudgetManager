using BudgetManager.Services;

namespace BudgetManager
{
    public partial class MainForm : Form
    {
        private readonly DatabaseService _databaseService = new DatabaseService();

        public MainForm()
        {
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
        }

        private void LoadBalance()
        {
            lblBalance.Text = $"₩ {_databaseService.GetBalance():N0}";
        }

        private void LoadMonthlySummary()
        {
            DateTime date = dtpMonth.Value;
            (decimal income, decimal expense) =_databaseService.GetMonthlyTotal(date);
            lblIncome.Text = $"이번 달 수입: ₩ {income:N0}";
            lblExpense.Text = $"이번 달 지출: ₩ {expense:N0}";
        }
    }
}
