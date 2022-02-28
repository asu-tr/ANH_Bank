using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class DebitCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; }

        [Required, ForeignKey("Account")]
        public int AccountId { get; set; }
        public Account Account { get; set; }

        [Required, ForeignKey("Currency")]
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }

        [Required]
        public string CardNo { get; set; }

        [Required]
        public string ExpirationDate { get; set; }

        [Required]
        public bool InUse { get; set; }


        public virtual ICollection<Payment> Payments { get; set; }
    }
}