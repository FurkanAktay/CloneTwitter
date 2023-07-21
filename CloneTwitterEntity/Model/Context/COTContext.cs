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

    }

    
}
