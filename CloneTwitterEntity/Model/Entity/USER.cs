using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Entity
{
    public class USER
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key()]
        public int ID_USER { get; set; }

        [StringLength(25)]
        public string NAME { get; set; }
        [StringLength(11)]
        public string PHONE { get; set; }
        [StringLength(50)]
        public string EMAIL { get; set; }
        [StringLength(25)]
        public string USERNAME { get; set; }
        [StringLength(25)]
        public string PASSWORD { get; set; }

    }
}
