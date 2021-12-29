﻿using CommonLayer.Model;
using RespositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interfaces
{
    public interface IUserBL
    {
        bool Registration(UserRegistration user);
        bool Login(UserLogin user1);
        IEnumerable<User> GetAlldata();
    }
}