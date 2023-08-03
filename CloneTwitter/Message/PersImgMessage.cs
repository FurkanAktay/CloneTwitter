using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Message
{
    public class PersImgRequest : MessagesRequest
    {
        public int UserID { get; set; }
        public string ProfilePic { get; set; }
        public string ProfileBgPic { get; set; }
        public string ProfileBio { get; set; }
    }

    public class PersImgResponse : MessagesResponse
    {
        public int UserPersId { get; set; }
    }
}
