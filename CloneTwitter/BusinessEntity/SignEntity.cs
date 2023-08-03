using CloneTwitterEntity;
using CloneTwitterEntity.Model.Context;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.BusinessEntity
{
    public class SignEntity
    {
        public static int USERADD(string name, string phone, string email, string username, string password)
        {
            USER tbluser = new USER();
            try
            {

                tbluser.NAME = name;
                tbluser.PHONE = phone;
                tbluser.EMAIL = email;
                tbluser.USERNAME = username;
                tbluser.PASSWORD = password;

                USERDAL.UserAdd(tbluser);

            }
            catch (System.Exception ex)
            {

                throw;
            }
            return tbluser.ID_USER;
        }

        public static USER USERSIGN(string PUEtext, string password)
        {
            USER tbluser = new USER();

            tbluser.PHONE = PUEtext;
            tbluser.EMAIL = PUEtext;
            tbluser.USERNAME = PUEtext;
            tbluser.PASSWORD = password;


            return USERDAL.UserSign(tbluser); ;
        }

        public static bool USEREXIST(USER tbluser)
        {
            var usersign = USERDAL.USERDONDUR(tbluser);

            if (usersign != null)
                return true;

            return false;

        }

        

    }
}
