using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Entity
{
    public class JOIN_USERPERSUSER
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        
        public string ProfilePic { get; set; }
        public string ProfileBgPic { get; set; }
        public string ProfileBio { get; set; }
    }
}
