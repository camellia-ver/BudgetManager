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
    }
}
