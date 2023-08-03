using CloneTwitterEntity.Model.Entity;
using CloneTwitterEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.BusinessEntity
{
    public class PostEntity
    {
        public static int SHAREPOST( int id_user, string user_photo, string post_content, string post_imgcontent)
        {
            POST tblpost = new POST();

            try
            {
                tblpost.ID_USER = id_user;
                tblpost.USER_PHOTO = user_photo;
                tblpost.POST_CONTENT = post_content;
                tblpost.POST_IMGCONTENT = post_imgcontent;

                POSTDAL.POSTADD(tblpost);

            }
            catch (System.Exception)
            {

                throw;
            }

            return tblpost.ID_POST;
        }

        

    }
}
