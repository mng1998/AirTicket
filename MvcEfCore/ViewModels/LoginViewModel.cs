﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEfCore.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        public string EmailOrUsername { get; set; }
       
        [Required]
        [DataType(DataType.Password)]       
        public string Password { get; set; }
        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
        [ScaffoldColumn(false)]
        public string ReturnUrl { get; set; }
    }
}
