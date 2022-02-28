using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class PaymentType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}