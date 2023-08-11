using CloneTwitterEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace CloneTwitter.Session
{
    public class SessionHelper
    {
        public static string GetUserPhoto(int userid)
        {
            
            string getUserImg = USERDAL.USERGETPIMG(userid).ToString();

            return getUserImg;
          
        }

        public static string GetUserName(int userid)
        {

            string getUserName = USERDAL.USERGETUSERNAME(userid).ToString();

            return getUserName;

        }

        public static string GetName(int userid)
        {

            string getName = USERDAL.USERGETNAME(userid).ToString();

            return getName;

        }

    }
}
