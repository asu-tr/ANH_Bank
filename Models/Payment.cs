using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime PaymentTime { get; set; }

        public Account Account { get; set; }

        public CreditCard CreditCard { get; set; }

        public DebitCard DebitCard { get; set; }
        

        [Required, ForeignKey("PaymentType")]
        public int PaymentTypeId { get; set; }
        public PaymentType PaymentType { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Description { get; set; }
    }
}