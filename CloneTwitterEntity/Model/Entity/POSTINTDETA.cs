using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Entity
{
    public class POSTINTDETA
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int InteractDetail_ID { get; set; }
        public int Interact_ID { get; set; }
        public int Post_ID { get; set; }
        public int User_ID { get; set; }
        public bool Like { get; set; }
        public bool Comment { get; set; }
        public string CommentContent { get; set; }

    }
}
