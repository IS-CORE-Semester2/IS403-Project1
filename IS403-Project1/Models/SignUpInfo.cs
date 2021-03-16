﻿using System.ComponentModel.DataAnnotations;

namespace IS403_Project1.Models
{
    public class SignUpInfo
    {
        [Key]
        [Required]
        public int GroupId { get; set; }
        [Required]
        public string GroupName { get; set; }
        [Required]
        public int GroupSize { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
