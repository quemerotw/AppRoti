using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AppRoti.Clases;
using System.Data.OleDb;

namespace AppRoti {
    public class RotiDbContext : DbContext{
        public RotiDbContext() : base("RotiDbContextConection") {
        }
        public DbSet<CCliente> ClienteTable { get;set;}

    }
}
