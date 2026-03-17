using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetManager.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TransactionType TransactionType { get; set; }
    }
}
