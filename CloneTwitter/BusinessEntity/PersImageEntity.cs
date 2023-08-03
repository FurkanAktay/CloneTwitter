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
            catch (System.Exception ex)
            {

                throw;
            }
            return tbluserpersimg.UserPersId;
        }




    }
}
