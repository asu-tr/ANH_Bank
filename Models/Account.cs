using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

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


        public virtual ICollection<DW> DWs { get; set; }
        public virtual ICollection<Exchange> ExchangeSell { get; set; }
        public virtual ICollection<Exchange> ExchangeBuy { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Transfer> TransfersSent { get; set; }
        public virtual ICollection<Transfer> TransfersReceived { get; set; }
    }
}