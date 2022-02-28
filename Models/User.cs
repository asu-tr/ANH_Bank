using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(11)]
        public string TCKN { get; set; }
        [Required]
        public string Password { get; set; }
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        [Required, MaxLength(20)]
        public string LastName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required, MaxLength(50)]
        public string Address { get; set; }
        [Required, MaxLength(15)]
        public string Phone { get; set; }
        [Required, MaxLength(50)]
        public string Email { get; set; }
        [Required, ForeignKey("SecurityQuestion")]
        public int SecurityQuestionId { get; set; }
        public SecurityQuestion SecurityQuestion { get; set; }
        [Required, MaxLength(20)]
        public string SecurityQuestionAnswer { get; set; }
        [Required]
        public bool InUse { get; set; }


        public List<Account> Accounts { get; set; }
        public List<CreditCard> CreditCards { get; set; }
        public List<DebitCard> DebitCards { get; set; }
    }
}