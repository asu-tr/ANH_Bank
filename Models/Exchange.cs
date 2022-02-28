using System;
using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class Exchange
    {
        [Key]
        public int Id { get; set; }
        public DateTime ExchangeTime { get; set; }
        public decimal Amount  { get; set; }
        public float Rate { get; set; }
        public Account FromAccount { get; set; }
        public Currency FromCurrency { get; set; }
        public Account ToAccount { get; set; }
        public Currency ToCurrency { get; set; }
    }
}