using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Message
{
    public class SharePostRequest : MessagesRequest
    {
        public int ID_USER { get; set; }
        public string USER_PHOTO { get; set;}
        public string POST_CONTENT { get; set;}
        public string POST_IMGCONTENT { get; set;}
        public bool ISVERIFIED { get; set;} 

    }

    public class SharePostResponse : MessagesResponse
    {
        public int ID_POST { get; set; }
    }
}
