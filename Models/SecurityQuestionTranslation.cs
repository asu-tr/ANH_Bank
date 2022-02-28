using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ANH_Bank.Models
{
    public class SecurityQuestionTranslation
    {
        [Key]
        public int Id { get; set; }

        public SecurityQuestion SecurityQuestion { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public bool IsDefault { get; set; }

        [Required]
        public string Translation { get; set; }
    }
}