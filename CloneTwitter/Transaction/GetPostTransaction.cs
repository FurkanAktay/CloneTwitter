using CloneTwitter.BusinessEntity;
using CloneTwitter.Enumaration;
using CloneTwitter.Message;
using CloneTwitterEntity;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Transaction
{
    public class GetPostTransaction
    {
        private static void Validate(GetPostRequest getPostRequest, GetPostResponse getPostResponse)
        {
            if (getPostRequest.UserId > 0)
                getPostResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Böyle bir kullanıcı yoktur."));


        }

        public static MessagesResponse Execute(GetPostRequest request)
        {

            GetPostResponse getPostResponse = new GetPostResponse();
            try
            {


                Validate(request, getPostResponse);



                var getPost = POSTDAL.GETPOST(request.UserId);

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("PostId", typeof(int));
                dataTable.Columns.Add("UserId", typeof(int));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("UserName", typeof(string));
                dataTable.Columns.Add("User_Photo", typeof(string));
                dataTable.Columns.Add("Post_Content", typeof(string));
                dataTable.Columns.Add("Post_imgcontent", typeof(string));


                getPost.Aggregate(dataTable, (d, r) =>
                {
                    d.Rows.Add(r.PostId,
                               r.UserId,
                               r.Name,
                               r.UserName,
                               string.IsNullOrEmpty(r.UserPhoto) ? string.Empty : r.UserPhoto,
                               string.IsNullOrEmpty(r.PostContent) ? string.Empty : r.PostContent,
                               string.IsNullOrEmpty(r.PostImgContent) ? string.Empty : r.PostImgContent
                               ); return d;
                });

                //son gönderinin en üstte çıkması için
                DataView view = dataTable.DefaultView;
                view.Sort = "PostId DESC";
                DataTable dtable = view.ToTable();

                getPostResponse.PostTable = dtable;
                return getPostResponse;

            }
            catch (System.Exception)
            {
                return getPostResponse;

            }











        }

    }
}
