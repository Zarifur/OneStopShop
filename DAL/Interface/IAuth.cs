﻿using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IAuth
    {
        User Authenticate(string Email, string Password);
        User GetUser(string Email);
        Token GetToken(string token);
    }
}
