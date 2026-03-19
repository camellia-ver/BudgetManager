using BudgetManager.Services;

namespace BudgetManager
{
    public partial class MainForm : Form
    {
        private readonly DatabaseService databaseService = new DatabaseService();

        public MainForm()
        {
            InitializeComponent();
        }
    }
}
