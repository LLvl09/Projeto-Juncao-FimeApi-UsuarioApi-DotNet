﻿using Microsoft.AspNetCore.Identity;
using System;

namespace UsuariosApi.Models
{
    public class CustomIdentityUser : IdentityUser<int>
    {
        public DateTime DataDeNascimento { get; set; }
    }
}
