using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CloneTwitterEntity.Model.Entity
{
    public class POST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int ID_POST { get; set; }

        //[ForeignKey("ID_USER")]
        public int ID_USER { get; set; }

        //public virtual USER USER { get; set; }

        public string USER_PHOTO { get; set; }
        public string POST_CONTENT { get; set; }
        public string POST_IMGCONTENT { get; set; }



    }
}
