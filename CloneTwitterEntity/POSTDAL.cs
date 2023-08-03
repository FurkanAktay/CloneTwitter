using CloneTwitterEntity.Model.Context;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity
{
    public class POSTDAL
    { 
        public static void POSTADD(POST tblpost)
        {
            using (COTContext Veri = new COTContext())
            {
                POST yenipost = new POST
                {
                    ID_USER = tblpost.ID_USER,
                    USER_PHOTO = tblpost.USER_PHOTO,
                    POST_CONTENT = tblpost.POST_CONTENT,
                    POST_IMGCONTENT = tblpost.POST_IMGCONTENT,
                };
                Veri.POSTS.Add(yenipost);
                Veri.SaveChanges();
                tblpost.ID_POST = yenipost.ID_POST;
            }
        }

        public static List<POST> GETPOST(int userId)
        {
            using (COTContext Veri = new COTContext())
            {
              return  Veri.POSTS.Where(p => p.ID_USER == userId).ToList();

            }
        }


    }
}
