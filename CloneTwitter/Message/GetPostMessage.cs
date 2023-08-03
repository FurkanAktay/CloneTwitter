using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitter.Message
{
    public class GetPostRequest : MessagesRequest
    {
        public int UserId { get; set; }
        
    }

    public class GetPostResponse : MessagesResponse
    {
        public DataTable PostTable { get; set; } = new DataTable();
        public string UserPhoto { get; set; }
        public string PostContent { get; set; }
        public string PostImgContent { get; set; }

    }
}
