using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class CreditCard
    {
        [Key]
        public int Id { get; set; }
        [Required, ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        [Required]
        public decimal Limit { get; set; }
        [Required]
        public string CardNo { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        [Required]
        public bool InUse { get; set; }
        [Required]
        public User User { get; set; }


        public List<Payment> Payments { get; set; }
    }
}