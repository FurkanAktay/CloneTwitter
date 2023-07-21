using CloneTwitter.Enumaration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CloneTwitter.Enumaration.GeneralEnumarations;

namespace CloneTwitter.Message
{
    public class MessagesRequest
    {

    }
    public class MessagesResponse
    {
        public string Content { get; set; }
        public GeneralEnumarations.Response Response { get; set; }

        public List<Notification> Notifications { get; set; } = new List<Notification>();

    }

    public class Notification
    {
        public EnumNotificationType NotType { get; set; }

        public string Message { get; set; }

        public Notification()
        {

        }
        public Notification(EnumNotificationType notitype, string Message)
        {
            this.NotType = notitype;
            this.Message = Message;
        }
    }
}
