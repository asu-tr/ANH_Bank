using System;
using System.Collections.Generic;

namespace ANH_Bank.Models
{
    public class User
    {
        public int Id { get; set; }
        public long TCKN { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public SecurityQuestion SecurityQuestion { get; set; }
        public string SecurityQuestionAnswer { get; set; }
        public bool InUse { get; set; }
        public List<Account> Accounts { get; set; } = new List<Account>();
        public List<DebitCard> DebitCards {get; set; } = new List<DebitCard>();
        public List<CreditCard> CreditCards { get; set; } = new List<CreditCard>();
    }
}