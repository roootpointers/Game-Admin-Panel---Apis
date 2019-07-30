using Project.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Project.Models.DataClasses
{
    public class SecurityClass
    {
        //Admin Login Check Class
        public static Admins GetLoginStatus(LoginViewModel lv)
        {
            AdminContext db = new AdminContext();
            Admins temp = new Admins(); 
            try
            {
                temp = db.Admins.FirstOrDefault(x => x.UserName.Equals(lv.Email) && x.Password.Equals(lv.Password));
                if (temp != null) 
                    return temp; 
            }
            catch (Exception) { 
                return temp;
            }
            return temp;
        } 
    }
}