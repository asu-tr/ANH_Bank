using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual List<Account> Accounts { get; set; }
    }
}