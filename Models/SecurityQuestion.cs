﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class SecurityQuestion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }
        public List<SecurityQuestionTranslation> SecurityQuestionTranslations { get; set; }
    }
}