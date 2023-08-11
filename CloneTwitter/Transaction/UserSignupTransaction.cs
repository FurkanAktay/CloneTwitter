using CloneTwitter.BusinessEntity;
using CloneTwitter.Enumaration;
using CloneTwitter.Message;
using CloneTwitter.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CloneTwitter.Enumaration.GeneralEnumarations;
using System.Text.RegularExpressions;
using CloneTwitterEntity;
using CloneTwitterEntity.Model.Entity;

namespace CloneTwitter.Transaction
{
    public class UserSignupTransaction
    {
        private static void Validate(UserSignupRequest userSaveRequest, UserSignupResponse userSaveResponse)
        {

            // "/^(05)([0-9]{2})\\s?([0-9]{3})\\s?([0-9]{2})\\s?([0-9]{2})$/"

            if (Regex.IsMatch(userSaveRequest.PHONE, "^(5)([0-9]{2})([0-9]{7})") == false)
                userSaveResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Telefon formatı geçersiz formattadır !"));

            if (userSaveRequest.PHONE.Length > 11)
                userSaveResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Telefon uzunluğu 10 karakterden uzun olamaz !"));

            if (userSaveRequest.PASSWORD.Length < 8)
                userSaveResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Şifre uzunluğu 8 karakterden küçük olamaz !"));

            if (ReferenceEquals(userSaveRequest.NAME, "") || ReferenceEquals(userSaveRequest.PHONE, "") || ReferenceEquals(userSaveRequest.USERNAME, "") || ReferenceEquals(userSaveRequest.PASSWORD, ""))
                userSaveResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Gerekli(*) alanlar eksiktir !"));

            if(SignEntity.USEREXIST(new USER { EMAIL = userSaveRequest.EMAIL , PHONE = userSaveRequest.PHONE , USERNAME = userSaveRequest.USERNAME}) )
                userSaveResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Girmiş olduğunuz verilerde kullanıcı bulunmaktadır ! "));

            if (userSaveResponse.Notifications.Any())
                throw new System.Exception(); 

        }

        public static MessagesResponse Execute(UserSignupRequest request)
        {
            UserSignupResponse userSaveResponse = new UserSignupResponse();
            try
            {


                Validate(request, userSaveResponse);

                int userid = SignEntity.USERADD(request.NAME, request.PHONE, request.EMAIL, request.USERNAME, request.PASSWORD);

                PersImageEntity.USERPERSIMGADD(userid, "https://st3.depositphotos.com/19428878/36416/v/450/depositphotos_364169666-stock-illustration-default-avatar-profile-icon-vector.jpg","","");

                return userSaveResponse;

            }
            catch (System.Exception)
            {
                return userSaveResponse;

            }

        }
    }
}
