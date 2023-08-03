using CloneTwitter.BusinessEntity;
using CloneTwitter.Enumaration;
using CloneTwitter.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CloneTwitter.Enumaration.GeneralEnumarations;

namespace CloneTwitter.Transaction
{
    public class UserSigninTransaction
    {
        private static void Validate(UserSigninRequest userSigninRequest, UserSigninResponse userSigninResponse)
        {

            if (string.IsNullOrEmpty(userSigninRequest.PASSWORD))
                userSigninResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Lütfen şifrenizi giriniz."));
            

            if (string.IsNullOrEmpty(userSigninRequest.PUEtext))
                userSigninResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error,"Lütfen Username, Email, Phone bilgilerinizden birini giriniz."));

            if (userSigninResponse.Notifications.Any())
                throw new System.Exception();

        }

        public static MessagesResponse Execute(UserSigninRequest request)
        {
            UserSigninResponse userSigninResponse = new UserSigninResponse();

            try
            {
                Validate(request, userSigninResponse);

                var user = SignEntity.USERSIGN(request.PUEtext,request.PASSWORD);
                
                if(user != null)
                {
                    userSigninResponse.ID_USER = user.ID_USER;
                }
                else
                {
                    userSigninResponse.ID_USER=0;
                    userSigninResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Kullanıcı Bulunamadı !"));

                }


                return userSigninResponse;
            }
            catch (System.Exception)
            {

                return userSigninResponse;
            }

            
        }


    }
}
