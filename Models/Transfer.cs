using System;
using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime TransferTime { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Description { get; set; }
        public Account Receiver { get; set; }
        public Account Sender { get; set; }
    }
}