using CloneTwitterEntity.Model.Context;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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

        public static List<JOIN_USERPOST> GETPOST(int userId)
        {
            using (COTContext Veri = new COTContext())
            {
                var result = Veri.POSTS
                    .Join(Veri.USERS,
                    n=> n.ID_USER,
                    p=>p.ID_USER,
                    (n,p)=> new
                    {
                        PostId = n.ID_POST,
                        UserId = n.ID_USER,
                        Name = p.NAME,
                        UserName = p.USERNAME,
                        UserPhoto  = n.USER_PHOTO,
                        PostContent = n.POST_CONTENT,
                        PostImgContent = n.POST_IMGCONTENT,
                    }).Where(p => p.UserId == userId).ToList();

                List<JOIN_USERPOST> ResultList = new List<JOIN_USERPOST>();
                foreach (var item in result)
                {
                    ResultList.Add(new JOIN_USERPOST()
                    {
                        PostId = item.PostId,
                        UserId = item.UserId,
                        Name = item.Name,
                        UserName = item.UserName,
                        UserPhoto = item.UserPhoto,
                        PostContent = item.PostContent,
                        PostImgContent = item.PostImgContent,
                    });
                }

                return ResultList;

            }
        }

        public static void POSTUPCHANGE(int userid,string usernewphoto)
        {
            using (COTContext Veri = new COTContext())
            {
                var posts = Veri.POSTS.Where(u => u.ID_USER == userid);

                
                foreach (var post in posts)
                {
                    post.USER_PHOTO = usernewphoto;
                }
                Veri.SaveChanges();


            }
        }


    }
}
