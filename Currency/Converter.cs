namespace ANH_Bank.Currency
{
    public class Converter
    {
        private string ApiKey { get; }

        public Converter(string apiKey)
        {
            ApiKey = apiKey;
        }

        public double Convert(double amount, CurrencyType from, CurrencyType to)
        {
            return RequestHelper.ExchangeRate(from, to, ApiKey) * amount;
        }
    }
}