using CloneTwitter.BusinessEntity;
using CloneTwitter.Message;
using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Transaction
{
    public class PersImageTransactions
    {
        private static void Validate(PersImgRequest persImgRequest, PersImgResponse persImgResponse)
        {




        }

        public static MessagesResponse Execute(PersImgRequest request)
        {
            PersImgResponse persImgResponse = new PersImgResponse();

            

            try
            {

                if (PersImageEntity.USEREXIST(new USERPERS { UserID = request.UserID}))
                {
                    int userpersid = PersImageEntity.USERPERSIMGUPDATE(request.UserID, request.ProfilePic, request.ProfileBgPic, request.ProfileBio);
                    
                    PersImageEntity.CHANGEPOSTP(request.UserID,request.ProfilePic);
                }
                
                else
                {
                    int userpersid = PersImageEntity.USERPERSIMGADD(request.UserID, request.ProfilePic, request.ProfileBgPic, request.ProfileBio);
                }      
                
                return persImgResponse;
            
            }
            catch (System.Exception)
            {

                return persImgResponse;
            }

            
        }

    }
}
