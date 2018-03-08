using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WeatherDTOs;

namespace WeatherAPI.Models
{
    public class Login
    {
        private WeatherEntities1 db = new WeatherEntities1();

        public bool validateUser(user user)
        {
            return db.users.Any(x => x.userId == user.userId);
        }

        public bool Newuser(user user)
        {
            try
            {
                db.users.Add(user);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }
    }
}