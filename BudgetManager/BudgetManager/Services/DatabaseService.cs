using BudgetManager.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

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
                cmd.Parameters.AddWithValue("@Type", (int)transaction.Type);
                cmd.Parameters.AddWithValue("@Category", transaction.Category);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Transaction> GetTransactions(DateTime startDate, DateTime endDate)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Transactions WHERE Date >= @StartDate AND Date <= @EndDate;";

            var transactions = new List<Transaction>();

            using (var cmd = new SqliteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                cmd.Parameters.AddWithValue("@EndDate", endDate);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //0: Id, 1: Amount, 2: Date, 3: Description, 4: Type, 5: Category
                    var transaction = new Transaction
                    {
                        Id = reader.GetInt32(0),
                        Amount = (decimal)reader.GetDouble(1),
                        Date = DateTime.Parse(reader.GetString(2)),
                        Description = reader.GetString(3),
                        Type = (TransactionType)reader.GetInt32(4),
                        Category = reader.GetString(5),
                    };

                    transactions.Add(transaction);
                }
            }

            return transactions;
        }

        public void UpdateTransaction(Transaction transaction)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "UPDATE Transactions SET Amount = @Amount, Date = @Date, Description = @Description, Type = @Type, Category = @Category WHERE Id = @Id;";

            using (var cmd = new SqliteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Id", transaction.Id);
                cmd.Parameters.AddWithValue("@Amount", transaction.Amount);
                cmd.Parameters.AddWithValue("@Date", transaction.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@Description", transaction.Description);
                cmd.Parameters.AddWithValue("@Type", (int)transaction.Type);
                cmd.Parameters.AddWithValue("@Category", transaction.Category);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTransaction(int id)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "DELETE FROM Transactions WHERE Id = @Id";

            using (var cmd = new SqliteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
