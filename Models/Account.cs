using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required, ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        [Required]
        public decimal Balance { get; set; }
        [Required]
        public decimal Overdraft { get; set; }
        [Required]
        public bool InUse { get; set; }
        [Required]
        public User User { get; set; }


        public List<DW> DWs { get; set; }
        public List<Payment> Payments { get; set; }
    }
}