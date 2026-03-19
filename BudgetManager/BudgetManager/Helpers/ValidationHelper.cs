using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetManager.Helpers
{
    public class ValidationHelper
    {
        public static bool IsValidAmount(string input)
        {
            if(string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if(!decimal.TryParse(input, out var amount))
            {
                return false;
            }

            if(amount <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
