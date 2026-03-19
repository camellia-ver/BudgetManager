using BudgetManager.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetManager.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string dbPath = "budget.db")
        {
            _connectionString = $"Data Source={dbPath}";
            InitializeDatabase();
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

            SeedDefaultCategories(connection);
        }

        private void SeedDefaultCategories(SqliteConnection connection)
        {
            var check = connection.CreateCommand();
            check.CommandText = "SELECT COUNT(*) FROM Categories";
            var count = (long)(check.ExecuteScalar() ?? 0);
            if (count > 0) return;

            var insert = connection.CreateCommand();
            insert.CommandText = @"
                INSERT INTO Categories (Name, Type) VALUES
                ('월급', 0), ('용돈', 0), ('기타수입', 0),
                ('식비', 1), ('교통비', 1), ('쇼핑', 1),
                ('의료비', 1), ('문화', 1), ('기타지출', 1);
            ";
            insert.ExecuteNonQuery();
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

        public decimal GetBalance()
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "SELECT COALESCE(SUM(CASE WHEN Type = 0 THEN Amount ELSE 0 END) - SUM(CASE WHEN Type = 1 THEN Amount ELSE 0 END), 0) FROM Transactions";

            using (var cmd = new SqliteCommand(sql, connection))
            {
                var result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }

        public (decimal income, decimal expense) GetMonthlyTotal(DateTime date)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = @"SELECT 
                            COALESCE(SUM(CASE WHEN Type = 0 THEN Amount ELSE 0 END), 0),
                            COALESCE(SUM(CASE WHEN Type = 1 THEN Amount ELSE 0 END), 0)
                        FROM Transactions
                        WHERE strftime('%Y', Date) = @Year AND strftime('%m', Date) = @Month";
            
            using (var cmd = new SqliteCommand(sql, connection))
            {
                cmd.Parameters.AddWithValue("@Year", date.Year.ToString("D4"));
                cmd.Parameters.AddWithValue("@Month", date.Month.ToString("D2"));

                using var reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    decimal income = (decimal)reader.GetDouble(0);
                    decimal expense = (decimal)reader.GetDouble(1);
                    return (income, expense);
                }

                return (0, 0);
            }
        }

        public List<Category> GetCategories(TransactionType type)
        {
            using var connection = new SqliteConnection(_connectionString);
            connection.Open();

            string sql = "SELECT * FROM Categories WHERE Type = @Type";
            var list = new List<Category>();

            using(var cmd = new SqliteCommand(sql,connection))
            {
                cmd.Parameters.AddWithValue("@Type", (int)type);

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Category
                    {
                        Id = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        TransactionType = (TransactionType)reader.GetInt32(2)
                    });
                }
            }

            return list;
        }
    }
}
