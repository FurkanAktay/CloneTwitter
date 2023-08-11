using CloneTwitterEntity.Model.Context;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

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

        public static void UserPersImgUpdate(USERPERS tbluserpersimg)
        {
            using (COTContext Veri = new COTContext())
            {
                var exist = Veri.USERPERSS.SingleOrDefault(u=>u.UserID==tbluserpersimg.UserID);

                if (exist != null)
                {
                    exist.ProfilePic = tbluserpersimg.ProfilePic;
                    exist.ProfileBgPic = tbluserpersimg.ProfileBgPic;
                    exist.ProfileBio = tbluserpersimg.ProfileBio;

                    Veri.SaveChanges() ;
                }
                else
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

        public static List<USERPERS> GETPIMG(int userId)
        {
            using (COTContext Veri = new COTContext())
            {
                return Veri.USERPERSS.Where(p => p.UserID == userId).ToList();

            }
        }

        public static string  USERGETPIMG(int userId)
        {
            using (COTContext Veri = new COTContext())
            {
                return Convert.ToString(Veri.USERPERSS.Where(p => p.UserID == userId).Select(p => p.ProfilePic).FirstOrDefault());

            }
        }

        public static string USERGETUSERNAME(int userId)
        {
            using (COTContext Veri = new COTContext())
            {
                return Convert.ToString(Veri.USERS.Where(p => p.ID_USER == userId).Select(p => p.USERNAME).FirstOrDefault());

            }
        }
        public static string USERGETNAME(int userId)
        {
            using (COTContext Veri = new COTContext())
            {
                return Convert.ToString(Veri.USERS.Where(p => p.ID_USER == userId).Select(p => p.NAME).FirstOrDefault());

            }
        }

        public static USERPERS UserPersImgDondur(USERPERS tbluserpers)
        {
            using (COTContext Veri = new COTContext())
            {

                // var test = Veri.USERS.Where(x => (x.ID_USER == Convert.ToInt32(Session["UserId"])));


                var userimgsave = Veri.USERPERSS.Where(x => (x.UserID == tbluserpers.UserID)).Select(x => x).FirstOrDefault();

                return userimgsave;
            }

        }



    }
}
