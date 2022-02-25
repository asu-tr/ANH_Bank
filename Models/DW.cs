using System;

namespace ANH_Bank.Models
{
    public class DW
    {
        public int Id { get; set; }
        public DateTime DWTime { get; set; }
        public Account Account { get; set; }
        public bool MoneyIn { get; set; }
        public decimal Amount { get; set; }
    }
}