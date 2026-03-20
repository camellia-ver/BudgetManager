using BudgetManager.Helpers;
using BudgetManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BudgetManager.Forms
{
    public partial class ExchangeRateForm : Form
    {
        private readonly ExchangeRateService _exchangeRateService;
        private Dictionary<string, double> _rates;

        public ExchangeRateForm()
        {
            InitializeComponent();
            _exchangeRateService = new ExchangeRateService();
        }

        private async void ExchangeRateForm_Load(object sender, EventArgs e)
        {
            _rates = await _exchangeRateService.GetExchangeRatesAsync();

            foreach (var rate in _rates)
            {
                cmbCurrency.Items.Add(rate.Key);
            }

            if (cmbCurrency.Items.Count > 0)
                cmbCurrency.SelectedIndex = 0;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.IsValidAmount(txtAmount.Text))
            {
                MessageBox.Show("올바른 금액을 입력해주세요.");
                return;
            }

            string selectedCurrency = cmbCurrency.SelectedItem.ToString();
            double result = double.Parse(txtAmount.Text) / _rates[selectedCurrency];

            lblResult.Text = $"결과: ₩ {result:N0}";
        }
    }
}
