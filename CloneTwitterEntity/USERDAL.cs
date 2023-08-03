using CloneTwitterEntity.Model.Context;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity
{
    public class USERDAL
    {
        public static void UserAdd(USER tbluser)
        {
            using (COTContext Veri = new COTContext())
            {

                USER yeniKullanici = new USER
                {
                    NAME = tbluser.NAME,
                    PHONE = tbluser.PHONE,
                    EMAIL = tbluser.EMAIL,
                    USERNAME = tbluser.USERNAME,
                    PASSWORD = tbluser.PASSWORD
                };
                Veri.USERS.Add(yeniKullanici);
                Veri.SaveChanges();
                tbluser.ID_USER = yeniKullanici.ID_USER;


            } 

        }

        public static USER USERDONDUR(USER tbluser)
        {
            using (COTContext Veri = new COTContext())
            {

                var usersign = Veri.USERS.Where(x => (x.USERNAME == tbluser.USERNAME || x.EMAIL == tbluser.EMAIL || x.PHONE == tbluser.PHONE) ).Select(x => x).FirstOrDefault();

                return usersign;
            }
        }

        public static USER UserSign(USER tbluser)
        {
            var usersign = USERDONDUR(tbluser);
            if (usersign == null) 
            {
                return null;            
            }


            if (usersign.PASSWORD==tbluser.PASSWORD)
            {
                return usersign;

            }

            return null;   


        }


        public static void UserPersImgAdd(USERPERS tbluserpersimg)
        {
            using (COTContext Veri = new COTContext())
            {

                USERPERS yeniKullaniciMedia = new USERPERS
                {
                    UserID = tbluserpersimg.UserID,
                    ProfilePic = tbluserpersimg.ProfilePic,
                    ProfileBgPic = tbluserpersimg.ProfileBgPic,
                    ProfileBio = tbluserpersimg.ProfileBio
                };
                Veri.USERPERSS.Add(yeniKullaniciMedia);
                Veri.SaveChanges();
                tbluserpersimg.UserPersId = yeniKullaniciMedia.UserPersId;


            }

        }


    }
}
