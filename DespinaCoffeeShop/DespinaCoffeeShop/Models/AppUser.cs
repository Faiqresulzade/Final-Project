﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DespinaCoffeeShop.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public bool IsActivated { get; set; }
        public Basket basket  { get; set; }
    }
}
