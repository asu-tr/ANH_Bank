using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class MessageTranslation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Language { get; set; }
        [Required]
        public bool IsDefault { get; set; }
        [Required]
        public string Translation { get; set; }
        public virtual Message Message { get; set; }
    }
}