using System;

namespace ANH_Bank.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public DateTime TransferTime { get; set; }
        public Account Sender { get; set; } 
        public Account Receiver { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}