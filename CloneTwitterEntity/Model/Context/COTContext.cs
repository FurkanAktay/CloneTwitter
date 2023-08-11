using CloneTwitterEntity.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CloneTwitterEntity.Model.Context
{
    public class COTContext : DbContext
    {
        
        public DbSet<Entity.USER> USERS { get; set; }

        public DbSet<POST> POSTS { get; set; }

        public DbSet<USERPERS> USERPERSS { get; set; } 

        public DbSet<POSTINT> POSTINTS { get; set; }    

        public DbSet<POSTINTDETA> POSTINTSDETAS { get; set;}

    }

    
}
