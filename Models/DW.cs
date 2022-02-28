﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ANH_Bank.Models
{
    public class DW
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DWTime { get; set; }
        [Required]
        public bool MoneyIn { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public Account Account { get; set; }
    }
}