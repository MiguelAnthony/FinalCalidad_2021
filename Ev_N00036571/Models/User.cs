﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_N00036571.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Password { get; set; }
    }
}