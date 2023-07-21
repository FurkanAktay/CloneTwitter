using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Message
{
    public class UserSigninRequest : MessagesRequest
    {
       
        public string PUEtext { get; set; }

        public string PASSWORD { get; set; }

    }

    public class UserSigninResponse : MessagesResponse
    {
        public int ID_USER { get; set; }
    }
}
