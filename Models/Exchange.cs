using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class Exchange
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ExchangeTime { get; set; }

        [Required, ForeignKey("FromCurrency")]
        public int FromCurrencyId { get; set; }
        public Currency FromCurrency { get; set; }

        [Required, ForeignKey("ToCurrency")]
        public int ToCurrencyId { get; set; }
        public Currency ToCurrency { get; set; }

        public Account FromAccount { get; set; }

        public Account ToAccount { get; set; }

        [Required]
        public decimal Amount  { get; set; }

        [Required]
        public float Rate { get; set; }
    }
}