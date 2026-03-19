using BudgetManager.Services;
using BudgetManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetManager.Forms
{
    public partial class TransactionForm : Form
    {
        private readonly DatabaseService _databaseService;

        public TransactionForm(DatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            rbIncome.Checked = true;
            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            TransactionType type = rbIncome.Checked
                ? TransactionType.Income
                : TransactionType.Expense;

            List<Category> categories = _databaseService.GetCategories(type);

            foreach (Category category in categories)
            {
                cmbCategory.Items.Add(category.Name);
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void rbIncome_CheckedChanged(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void rbExpense_CheckedChanged(object sender, EventArgs e)
        {
            LoadCategories();
        }
    }
}
