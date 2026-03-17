using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using BudgetManager.Models;

namespace BudgetManager.Services
{
    internal class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string dbPath = "budget.db")
        {
            _connectionString = $"Data Source={dbPath}";
        }

        private void InitializeDatabase()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "CREATE TABLE IF NOT EXISTS Transactions(" +
                "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Amount REAL NOT NULL," +
                "Date TEXT NOT NULL," +
                "Description TEXT," +
                "Type INTEGER NOT NULL," +
                "Category TEXT NOT NULL" +
                ");";

            using(var cmd = new SqliteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }

            sql = "CREATE TABLE IF NOT EXISTS Categories(" +
                "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "Name TEXT NOT NULL," +
                "Type INTEGER NOT NULL" +
                ");";

            using(var cmd = new SqliteCommand(sql, connection))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void AddTransaction(Transaction transaction)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "INSERT INTO Transactions(Amount, Date, Description,Type, Category)" +
                "VALUES(@Amount, @Date, @Description, @Type, @Category);";

            using(var cmd = new SqliteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@Date", transaction.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Description", transaction.Description);
                cmd.Parameters.AddWithValue("@Type", transaction.Type);
                cmd.Parameters.AddWithValue("@Category", transaction.Category);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
