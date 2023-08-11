using CloneTwitter.BusinessEntity;
using CloneTwitter.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Transaction
{
    public class SharePostTransaction
    {
        private static void Validate (SharePostRequest sharePostRequest,SharePostResponse sharePostResponse)
        {

        }

        public static MessagesResponse Execute(SharePostRequest request)
        {
            SharePostResponse sharePostResponse = new SharePostResponse();

            try
            {
                //Validate (request, sharePostResponse);

                int postid = PostEntity.SHAREPOST(request.ID_USER,request.USER_PHOTO,request.POST_CONTENT,request.POST_IMGCONTENT);


                return sharePostResponse;

            }
            catch (System.Exception)
            {

                return sharePostResponse;
            }

        }



    }
}
