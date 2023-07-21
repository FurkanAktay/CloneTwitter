using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Message
{
    public class UserSignupRequest : MessagesRequest
    {
        public string NAME { get; set; }
        public string PHONE { get; set; }
        public string EMAIL { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }


    }
    public class UserSignupResponse : MessagesResponse
    {
        public int ID_USER { get; set; }

    }
}
