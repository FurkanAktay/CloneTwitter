using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Entity
{
    public class JOIN_USERPOST
    {
        public int UserId { get; set; }
        public int PostId { get; set; } 
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserPhoto { get; set; }
        public string PostContent { get; set; }
        public string PostImgContent { get; set; }
    }
}
