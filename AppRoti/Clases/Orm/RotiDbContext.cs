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
        public DbSet<CProducto> ProductoTable { get; set; }
        public DbSet<CPedido> PedidosTable { get; set; }
        public DbSet<CDetallePedido> DetallesTable {get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            #region Mapeos

            modelBuilder.Entity<CDetallePedido>()
                .ToTable("DetallePedido")
                .HasKey(dp => dp.Id)
                .HasRequired(prod => prod.Producto);

            /*modelBuilder.Entity<CDetallePedido>()
                .HasRequired(dp => dp.Pedido)
                .WithMany(p => p.DetallePedido);
            */
            //CPedido map
            modelBuilder.Entity<CPedido>()
                .ToTable("Pedido")
                .HasKey(p => p.Id)
                .HasMany(p => p.DetallePedido)
                .WithRequired(dp => dp.Pedido);


            //CpedidoDelivery Map
            modelBuilder.Entity<CPedidoDelivery>().Map(m => {
                m.MapInheritedProperties();
                m.ToTable("Pedido");
            }).HasKey(p => p.Id);

            //Ccliente Map
            modelBuilder.Entity<CCliente>()
                .ToTable("Cliente")
                .HasKey(c => c.Id);

            //Cproducto Map
            modelBuilder.Entity<CProducto>()
                .ToTable("Producto")
                .HasKey(prod => prod.Id);
            #endregion
        }
    }
}
