﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookieAuthentication.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please, input email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password not set")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password not valid")]
        public string ConfirmPassword { get; set; }
    }
}
