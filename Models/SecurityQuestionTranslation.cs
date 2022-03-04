using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class SecurityQuestionTranslation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public bool IsDefault { get; set; }
        [Required]
        public string Translation { get; set; }
        public virtual SecurityQuestion SecurityQuestion { get; set; }
    }
}