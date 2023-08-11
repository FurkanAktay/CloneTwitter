using CloneTwitterEntity.Model.Entity;
using CloneTwitterEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.BusinessEntity
{
    public class PersImageEntity
    {
        public static int USERPERSIMGADD(int userid, string profilepic, string profilebgpic, string profilebio)
        {
            USERPERS tbluserpersimg = new USERPERS();
            try
            {

                tbluserpersimg.UserID = userid;
                tbluserpersimg.ProfilePic = profilepic;
                tbluserpersimg.ProfileBgPic = profilebgpic;
                tbluserpersimg.ProfileBio = profilebio;

                USERDAL.UserPersImgAdd(tbluserpersimg);

            }
            catch (System.Exception)
            {

                throw;
            }
            return tbluserpersimg.UserPersId;
        }

        public static int USERPERSIMGUPDATE(int userid, string profilepic, string profilebgpic, string profilebio)
        {
            USERPERS tbluserpersimg = new USERPERS();
            try
            {

                tbluserpersimg.UserID = userid;
                tbluserpersimg.ProfilePic = profilepic;
                tbluserpersimg.ProfileBgPic = profilebgpic;
                tbluserpersimg.ProfileBio = profilebio;

                USERDAL.UserPersImgUpdate(tbluserpersimg);

            }
            catch (System.Exception)
            {

                throw;
            }
            return tbluserpersimg.UserPersId;
        }


        public static bool USEREXIST(USERPERS tbluserpers)
        {
            var userpersimg = USERDAL.UserPersImgDondur(tbluserpers);

            if (userpersimg != null)
                return true;

            return false;

        }

        public static void CHANGEPOSTP(int userid, string newphoto)
        {
            try
            {
                POSTDAL.POSTUPCHANGE(userid, newphoto);

            }
            catch (System.Exception)
            {

                throw;
            }
        }




    }
}
