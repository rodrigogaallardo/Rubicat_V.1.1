using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Data
{
    public class DBRubicatContext : DbContext
    {
        private void FixEfProviderServicesProblem()
        {
            // The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            // for the 'System.Data.SqlClient' ADO.NET provider could not be loaded.
            // Make sure the provider assembly is available to the running application.
            // See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DBRubicatContext() : base("DBRubicat") { }
        public DbSet<Entidades.Venta> Ventas { get; set; }
        public DbSet<Entidades.Cliente> Clientes { get; set; }
        public DbSet<Entidades.Producto> Productos { get; set; }
        public DbSet<Entidades.Vendedor> Vendedores { get; set; }
        public DbSet<Entidades.Zona> Zonas { get; set; }
        public DbSet<Entidades.DetalleVenta> DetalleVentas { get; set; }

        public DbSet<Entidades.Deposito> Depositos { get; set; }
        public DbSet<Entidades.IngresoStock> IngresosStock { get; set; }
        public DbSet<Entidades.MateriaPrima> MateriaPrimas { get; set; }
        //public DbSet<Entidades.Stock> Stocks { get; set; }
        public DbSet<Entidades.Transporte> Transportes { get; set; }
        public DbSet<Entidades.Pedido> Pedidos { get; set; }
        public DbSet<Entidades.Aprobado> Aprobados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TablaAprobados
            modelBuilder.Entity<Entidades.Aprobado>().HasKey(a => a.IdAprobados);
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.NumeroDeRemito).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.FechaDePedido).IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.FechaDeEntrega).IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.ClienteId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.TransporteId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.ProductoId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Aprobado>().Property(a => a.ValorFinal).IsRequired().HasPrecision(14, 2);
            modelBuilder.Entity<Entidades.Aprobado>().ToTable("Aprobados");
            //TablaCliente
            modelBuilder.Entity<Entidades.Cliente>().HasKey(c => c.IdCliente);
            modelBuilder.Entity<Entidades.Cliente>().HasMany(c => c.Ventas).WithRequired().HasForeignKey(c => c.ClienteId);
            modelBuilder.Entity<Entidades.Cliente>().HasMany(c => c.Pedidos).WithRequired().HasForeignKey(c => c.ClienteId);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.CodCliente).HasColumnType("varchar").HasMaxLength(50).HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Nombre).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.RazonSocial).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Cuit).HasColumnType("decimal");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.IngBrutos).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.TipoIngBrutos).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.DomicilioFiscal).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Telefono).HasColumnType("decimal");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.VendedorId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.ZonaId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.TransporteId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Mail).HasColumnType("varchar");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Localidad).HasColumnType("varchar");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.CondicionVenta).HasColumnType("varchar");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.HorarioAtencion).HasColumnType("varchar");
            modelBuilder.Entity<Entidades.Cliente>().ToTable("Cliente");
            //TablaDeposito
            modelBuilder.Entity<Entidades.Deposito>().HasKey(d => d.IdDeposito);
            modelBuilder.Entity<Entidades.Deposito>().HasMany(d => d.IngresosStock).WithRequired().HasForeignKey(d => d.DepositoId);
            modelBuilder.Entity<Entidades.Deposito>().Property(d => d.Nombre).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Deposito>().Property(d => d.Descripcion).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Deposito>().Property(d => d.Espacio).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Deposito>().ToTable("Depositos");
            //TablaDetalleVenta
            modelBuilder.Entity<Entidades.DetalleVenta>().HasKey(d => new { d.VentaId, d.ProductoId });
            modelBuilder.Entity<Entidades.DetalleVenta>().HasRequired(d => d.Producto).WithMany().HasForeignKey(d => d.ProductoId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.DetalleVenta>().HasRequired(d => d.Venta).WithMany().HasForeignKey(d => d.VentaId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Cantidad).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Precio).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Costo).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Peso).IsRequired().HasColumnType("float");
            modelBuilder.Entity<Entidades.DetalleVenta>().ToTable("DetalleVenta");
            //TablaIngresoStocks
            modelBuilder.Entity<Entidades.IngresoStock>().HasKey(i => i.IdIngreso);
            //modelBuilder.Entity<Entidades.IngresoStock>().HasMany(i => i.Stocks).WithRequired().HasForeignKey(i => i.ProductoId);
            modelBuilder.Entity<Entidades.IngresoStock>().HasMany(i => i.Pedidos).WithRequired().HasForeignKey(p => p.ProductoId);
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.FechaIngreso).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.Cantidad).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.CantidadMinima).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.SumaUnidadesIngresados).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.SumaUnidadesUsadas).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.StockFinal).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.Status).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.DepositoId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.ProductoId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.Responsable).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.IngresoStock>().ToTable("IngresosStock");
            //TablaMateriaPrimas
            modelBuilder.Entity<Entidades.MateriaPrima>().HasKey(m => m.IdMateriaPrima);
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.CodigoMateriaPrima).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.DescripcionMateriaPrima).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            //modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.NombreMateriaPrima).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.KgUniMateriaPrima).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.UnidadMateriaPrima).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.CostoMateriaPrima).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.MateriaPrima>().ToTable("MateriasPrimas");
            //TablaPedidos
            modelBuilder.Entity<Entidades.Pedido>().HasKey(p => p.IdPedido);
            //modelBuilder.Entity<Entidades.Pedido>().HasMany(p => p.Stocks).WithRequired().HasForeignKey(p => p.NumeroDeRemitoId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.NumeroDeRemito).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.FechaDePedido).IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.FechaDeEntrega).IsRequired().HasColumnType("datetime");
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.ClienteId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.TransporteId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.ProductoId).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Pedido>().Property(p => p.ValorFinal).IsRequired().HasPrecision(14, 2);
            modelBuilder.Entity<Entidades.Pedido>().ToTable("Pedidos");
            //TablaProducto
            modelBuilder.Entity<Entidades.Producto>().HasKey(p => p.IdProducto);
            modelBuilder.Entity<Entidades.Producto>().HasMany(p => p.DetalleVentas).WithRequired().HasForeignKey(p => p.ProductoId);
            //modelBuilder.Entity<Entidades.Producto>().HasMany(p => p.Pedidos).WithRequired().HasForeignKey(p => p.ProductoId);
            modelBuilder.Entity<Entidades.Producto>().HasMany(p => p.IngresosStock).WithRequired().HasForeignKey(p => p.ProductoId);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.CodProducto).HasColumnType("varchar").HasMaxLength(50).HasColumnAnnotation("Index", new IndexAnnotation(new[] { new IndexAttribute("Index") { IsUnique = true } }));
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Nombre).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Familia).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Arquetipo).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Descripcion).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Peso).IsRequired().HasPrecision(30, 2);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.uniDeMedida).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Costo).IsRequired().HasPrecision(30, 2);
            modelBuilder.Entity<Entidades.Producto>().ToTable("Producto");
            //TablaStock
            //modelBuilder.Entity<Entidades.Stock>().HasKey(s => s.IdStockTotal);
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.ProductoId).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.NumeroDeRemitoId).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.SumaUnidadesIngresados).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.SumaUnidadesUsadas).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.StockFinal).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.StockMinimo).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().Property(s => s.Status).HasColumnType("int");
            //modelBuilder.Entity<Entidades.Stock>().ToTable("Stock");
            //TablaTransporte
            modelBuilder.Entity<Entidades.Transporte>().HasKey(t => t.IdTransporte);
            modelBuilder.Entity<Entidades.Transporte>().HasMany(t => t.Clientes).WithRequired().HasForeignKey(t => t.TransporteId);
            modelBuilder.Entity<Entidades.Transporte>().HasMany(t => t.Pedidos).WithRequired().HasForeignKey(t => t.TransporteId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Entidades.Transporte>().Property(t => t.NombreTransporte).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Transporte>().Property(t => t.DireccionTransporte).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Transporte>().Property(t => t.CaracterTransporte).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Transporte>().Property(t => t.HorarioDeTransporte).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Transporte>().Property(t => t.TelefonoTransporte).IsRequired().HasColumnType("decimal");
            modelBuilder.Entity<Entidades.Transporte>().ToTable("Transportes");
            //TablaVendedor
            modelBuilder.Entity<Entidades.Vendedor>().HasKey(v => v.IdVendedor);
            modelBuilder.Entity<Entidades.Vendedor>().HasMany(v => v.Ventas).WithRequired().HasForeignKey(v => v.VendedorId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Entidades.Vendedor>().HasMany(v => v.Clientes).WithRequired().HasForeignKey(v => v.VendedorId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.Vendedor>().Property(v => v.Nombre).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Vendedor>().Property(v => v.Telefono).HasColumnType("decimal");
            modelBuilder.Entity<Entidades.Vendedor>().Property(v => v.ZonaId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Vendedor>().ToTable("Vendedor");
            //TablaVenta
            modelBuilder.Entity<Entidades.Venta>().HasKey(v => v.IdVenta);
            modelBuilder.Entity<Entidades.Venta>().HasMany(v => v.DetalleVentas).WithRequired().HasForeignKey(v => v.VentaId);
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.Cantidad).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.Peso).HasColumnType("float");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.Importe).HasColumnType("money");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.RentBruta).HasColumnType("money");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.Cvm).HasColumnType("money");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.ClienteId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.VendedorId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Venta>().Property(v => v.Fecha).HasColumnType("datetime");
            modelBuilder.Entity<Entidades.Venta>().ToTable("Venta");
            //TablaZona
            modelBuilder.Entity<Entidades.Zona>().HasKey(z => z.IdZona);
            modelBuilder.Entity<Entidades.Zona>().HasMany(z => z.Vendedores).WithRequired().HasForeignKey(z => z.ZonaId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Entidades.Zona>().HasMany(z => z.Clientes).WithRequired().HasForeignKey(z => z.ZonaId);
            modelBuilder.Entity<Entidades.Zona>().Property(z => z.Nombre).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Zona>().ToTable("Zona");

        }
    }
}
