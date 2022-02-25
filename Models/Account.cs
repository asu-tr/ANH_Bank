using System.Collections.Generic;

namespace ANH_Bank.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public Currency Currency { get; set; }
        public decimal Balance { get; set; }
        public decimal Overdraft { get; set; }
        public bool InUse { get; set; }

    }
}