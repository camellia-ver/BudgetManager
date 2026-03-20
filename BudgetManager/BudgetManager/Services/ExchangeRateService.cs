using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace BudgetManager.Services
{
    public class ExchangeRateService
    {
        private readonly HttpClient _httpClient;

        public ExchangeRateService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<Dictionary<string, double>> GetExchangeRatesAsync()
        {
            string url = "https://open.er-api.com/v6/latest/KRW";

            var response = await _httpClient.GetStringAsync(url);

            var json = JsonDocument.Parse(response);
            var rates = json.RootElement.GetProperty("rates");

            var result = new Dictionary<string, double>();
            foreach(var rate in rates.EnumerateObject())
            {
                result[rate.Name] = rate.Value.GetDouble();
            }

            return result;
        }
    }
}
