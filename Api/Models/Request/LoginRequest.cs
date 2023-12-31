﻿using System.ComponentModel.DataAnnotations;

namespace Api.Models.Request
{
    public class LoginRequest
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
