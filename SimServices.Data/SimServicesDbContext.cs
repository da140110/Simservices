using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimServices.Model;
using Si

namespace SimServices.Data
{
    public class SimServicesDbContext : DbContext
    {
        public SimServicesDbContext() : base ("SimServicesConnection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet <Footer>
    }
}
