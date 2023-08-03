using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Entity
{
    public class USERPERS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int UserPersId { get; set; }

        
        //public virtual USER USER { get; set; }
        //[ForeignKey("ID_USER")]
        public int UserID { get; set; }
        public string ProfilePic { get; set; }
        public string ProfileBgPic { get; set; }
        public string ProfileBio { get; set; }


    }
}
