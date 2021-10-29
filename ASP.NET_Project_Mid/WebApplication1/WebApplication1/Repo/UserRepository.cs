﻿using WebApplication1.Models.EF;
using WebApplication1.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Repo
{
    public class UserRepository
    {
        static HomeRentEntities1 db;
        static UserRepository()
        {
            db = new HomeRentEntities1();
        }

        public static User Get(string email)
        {
            var u = (from us in db.Users
                     where us.Email == email
                     select us).FirstOrDefault();
            return u;
        }

        public static User Authenticate(string email,string password)
        {
            var u = (from us in db.Users
                     where us.Email == email &&
                     us.Password == password
                     select us).FirstOrDefault();
            var user = db.Users.FirstOrDefault(e => u.Email == email && u.Password == password);
            return u;
        }
        /* public int GetUserType(string email)
        {
            int type = 0;
            int ty = (from typ in db.Users
                     where typ.Type == Type 
                     select typ).FirstOrDefault();
            var user = db.Users.FirstOrDefault(e => ty.Type == Type && u.Password == password);
            return ty;
        } */


    }
}