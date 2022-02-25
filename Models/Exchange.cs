using System;

namespace ANH_Bank.Models
{
    public class Exchange
    {
        public int Id { get; set; }
        public DateTime ExchangeTime { get; set; }
        public Currency FromCurrency { get; set; }
        public Currency ToCurrency { get; set; }
        public Account FromAccount { get; set; }
        public Account ToAccount { get; set; }
        public decimal Amount  { get; set; }
        public float Rate { get; set; }
    }
}