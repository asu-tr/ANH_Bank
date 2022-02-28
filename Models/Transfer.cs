using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class Transfer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime TransferTime { get; set; }

        public Account Sender { get; set; }

        public Account Receiver { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public string Description { get; set; }
    }
}