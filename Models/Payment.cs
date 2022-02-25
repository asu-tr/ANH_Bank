using System;

namespace ANH_Bank.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime PaymentTime { get; set; }
        public Account Account { get; set; }
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
    }
}