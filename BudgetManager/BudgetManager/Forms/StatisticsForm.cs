using BudgetManager.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.WinForms;

namespace BudgetManager.Forms
{
    public partial class StatisticsForm : Form
    {
        private readonly DatabaseService _databaseService;
        private FormsPlot _pieChart;
        private FormsPlot _barChart;

        public StatisticsForm(DatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;
            InitializeCharts();
        }

        private void InitializeCharts()
        {
            _pieChart = new FormsPlot();
            _pieChart.Dock = DockStyle.Fill;

            _barChart = new FormsPlot();
            _barChart.Dock = DockStyle.Fill;

            tlpCharts.Controls.Add(_pieChart, 0, 0);
            tlpCharts.Controls.Add(_barChart, 1, 0);
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

        }

        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadChart()
        {

        }

        private void LoadPieChart()
        {
            var data = _databaseService.GetCategoryExpenses(dtpMonth.Value);

            _pieChart.Plot.Clear();

            double[] values = data.Select(d => (double)d.amount).ToArray();
            string[] lables = data.Select(d => d.category).ToArray();

            _pieChart.Plot.Add.Pie(values);
            _pieChart.Plot.Title("카테고리별 지출");
            _pieChart.Refresh();
        }

        private void LoadBarChart()
        {
            _barChart.Plot.Clear();

            double[] incomes = new double[6];
            double[] expenses = new double[6];
            string[] labels = new string[6];

            for (int i = 5; i > 0; i--)
            {
                DateTime date = dtpMonth.Value.AddMonths(-i);
                var (income, expense) = _databaseService.GetMonthlyTotal(date);

                incomes[5 - i] = (double)income;
                expenses[5 - i] = (double)expense;
                labels[5 - i] = date.ToString("yyyy-MM");
            }

            var bar1 = _barChart.Plot.Add.Bars(incomes);
            bar1.Color = ScottPlot.Color.FromHex("#4CAF50");

            var bar2 = _barChart.Plot.Add.Bars(expenses);
            bar2.Color = ScottPlot.Color.FromHex("#F44336");

            _barChart.Plot.Title("월별 수입/지출");
            _barChart.Refresh();
        }
    }
}
