using BudgetManager.Models;
using ClosedXML.Excel;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BudgetManager.Services
{
    public class FileService
    {
        public static void ExportToCsv(List<Transaction> transactions, string filePath)
        {
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteRecords(transactions);
        }

        public static void ExportExcel(List<Transaction> transactions, string filePath)
        {
            var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("거래내역");

            worksheet.Cell(1, 1).Value = "날짜";
            worksheet.Cell(1, 2).Value = "금액";
            worksheet.Cell(1, 3).Value = "구분";
            worksheet.Cell(1, 4).Value = "카테고리";
            worksheet.Cell(1, 5).Value = "설명";

            for (int i = 0; i < transactions.Count; i++)
            {
                var t = transactions[i];
                worksheet.Cell(i + 2, 1).Value = t.Date.ToString("yyyy-MM-dd");
                worksheet.Cell(i + 2, 2).Value = (double)t.Amount;
                worksheet.Cell(i + 2, 3).Value = t.Type == TransactionType.Income ? "수입" : "지출";
                worksheet.Cell(i + 2, 4).Value = t.Category;
                worksheet.Cell(i + 2, 5).Value = t.Description;
            }

            workbook.SaveAs(filePath);
        }

        public static List<Transaction> ImportFromCsv(string filePath)
        {
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            return csv.GetRecords<Transaction>().ToList();
        }
    }
}
