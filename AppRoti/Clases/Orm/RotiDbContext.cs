using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRoti.Clases {
    public class RotiDbContext : DbContext {
        public RotiDbContext() : base("RotiDb") {

        }
        public DbSet<CCliente> ClientesTable { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}
