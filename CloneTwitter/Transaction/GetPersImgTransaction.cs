using CloneTwitter.Enumaration;
using CloneTwitter.Message;
using CloneTwitterEntity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Transaction
{
    public class GetPersImgTransaction
    {
        private static void Validate(GetPersImgRequest getPersImgRequest, GetPersImgResponse getPersImgResponse)
        {
            if (getPersImgRequest.UserId > 0)
                getPersImgResponse.Notifications.Add(new Notification(GeneralEnumarations.EnumNotificationType.Error, "Böyle bir kullanıcı yoktur."));

        }

        public static MessagesResponse Execute(GetPersImgRequest request)
        {
            GetPersImgResponse gpiResponse = new GetPersImgResponse();

            try
            {
                Validate(request, gpiResponse);

                var getUserImg = USERDAL.GETPIMG(request.UserId);

                DataTable dataTable = new DataTable();

                dataTable.Columns.Add("UserId", typeof(int));
                dataTable.Columns.Add("UserName", typeof(string));
                dataTable.Columns.Add("Name", typeof(string));
                dataTable.Columns.Add("ProfilePic", typeof(string));
                dataTable.Columns.Add("ProfileBgPic", typeof(string));
                dataTable.Columns.Add("ProfileBio", typeof(string));

                getUserImg.Aggregate(dataTable, (d, r) =>
                {
                    d.Rows.Add(r.UserId,
                               r.UserName,
                               r.Name,
                               string.IsNullOrEmpty(r.ProfilePic) ? string.Empty : r.ProfilePic,
                               string.IsNullOrEmpty(r.ProfileBgPic) ? string.Empty : r.ProfileBgPic,
                               string.IsNullOrEmpty(r.ProfileBio) ? string.Empty : r.ProfileBio
                               ); return d;
                });

                gpiResponse.PostTable = dataTable;
                return gpiResponse;

            }
            catch (System.Exception)
            {

                return gpiResponse;
            }


        }







    }
}
