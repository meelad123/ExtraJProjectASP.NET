using SlaktData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlaktData
{
    public class SecurityUtility
    {
        private const string SessionName = "user";
        public static bool AuthenticateUser(User u)
        {
            User nUser = User.CheckUser(u);
            if ((nUser != null) && (nUser.password == u.password))
            {
                CreateSession(nUser);
                return true;
            }
            return false;
        }

        private static void CreateSession(User u) 
        {
            HttpContext.Current.Session[SessionName] = u;
        }
    }
}