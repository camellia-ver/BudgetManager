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
        }

        private void LoadBalance()
        {
            lblBalance.Text = $"₩ {_databaseService.GetBalance():N0}";
        }
    }
}
