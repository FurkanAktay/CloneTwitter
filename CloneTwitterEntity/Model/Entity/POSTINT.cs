using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Entity
{
    public class POSTINT
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int Interact_ID { get; set; }
        public int PostId { get; set; }
        public int Like_Sum { get; set; }
        public int Comment_Sum { get; set; }
    }
}
