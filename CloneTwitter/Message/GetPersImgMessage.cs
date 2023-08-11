using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Message
{
    public class GetPersImgRequest : MessagesRequest
    {
        public int UserId { get; set; }
    }

    public class GetPersImgResponse : MessagesResponse
    {
        public DataTable PostTable { get; set; } = new DataTable();

        public string ProfilePic { get; set; }
        public string ProfileBgPic { get; set; }
        public string ProfileBio { get; set; }
    }
}
