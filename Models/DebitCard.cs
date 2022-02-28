using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class DebitCard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CardNo { get; set; }
        [Required]
        public string ExpirationDate { get; set; }
        [Required]
        public bool InUse { get; set; }
        public Account Account { get; set; }
        public Currency Currency { get; set; }
        [Required]
        public User User { get; set; }


        public List<Payment> Payments { get; set; }
    }
}