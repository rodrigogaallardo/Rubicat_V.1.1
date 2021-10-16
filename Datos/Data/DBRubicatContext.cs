﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
        public DbSet<Entidades.Stock> Stocks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //TablaDeposito
            modelBuilder.Entity<Entidades.Deposito>().HasKey(d => d.IdDeposito);
            modelBuilder.Entity<Entidades.Deposito>().HasMany(d => d.IngresosStock).WithRequired().HasForeignKey(d => d.DepositoId);
            modelBuilder.Entity<Entidades.Deposito>().Property(d => d.Nombre).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Deposito>().Property(d => d.Descripcion).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Deposito>().Property(d => d.Espacio).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Deposito>().ToTable("Depositos");
            //TablaStock
            modelBuilder.Entity<Entidades.Stock>().HasKey(s => s.IdStockTotal);
            //modelBuilder.Entity<Entidades.Stock>().HasKey(s => new { s.DepositoID, s.MateriaPrimaID });
            modelBuilder.Entity<Entidades.Stock>().HasRequired(s => s.Deposito).WithMany().HasForeignKey(s => s.DepositoID).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.Stock>().HasRequired(s => s.MateriaPrima).WithMany().HasForeignKey(s => s.MateriaPrimaID).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.Stock>().Property(s => s.Cantidad).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.Stock>().ToTable("Stock");
            //TablaIngresoStocks
            modelBuilder.Entity<Entidades.IngresoStock>().HasKey(i => i.IdIngreso);
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.FechaIngreso).IsRequired().HasColumnType("date");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.Cantidad).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.NumeroRemito).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.IngresoStock>().Property(i => i.Responsable).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.IngresoStock>().ToTable("IngresosStock");
            //MateriaPrimas
            modelBuilder.Entity<Entidades.MateriaPrima>().HasKey(m => m.IdMateriaPrima);
            modelBuilder.Entity<Entidades.MateriaPrima>().HasMany(m => m.IngresosStock).WithRequired().HasForeignKey(m => m.MateriaPrimaId);
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.NombreMateriaPrima).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.MateriaPrima>().Property(m => m.CostoMateriaPrima).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.MateriaPrima>().ToTable("MateriasPrimas");

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

            //TablaCliente
            modelBuilder.Entity<Entidades.Cliente>().HasKey(c => c.IdCliente);
            modelBuilder.Entity<Entidades.Cliente>().HasMany(c => c.Ventas).WithRequired().HasForeignKey(c => c.ClienteId);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Nombre).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.RazonSocial).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Cuit).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.IngBrutos).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.TipoIngBrutos).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.DomicilioFiscal).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.Telefono).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.VendedorId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().Property(c => c.ZonaId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Cliente>().ToTable("Cliente");

            //TablaProducto
            modelBuilder.Entity<Entidades.Producto>().HasKey(p => p.IdProducto);
            modelBuilder.Entity<Entidades.Producto>().HasMany(p => p.DetalleVentas).WithRequired().HasForeignKey(p => p.ProductoId);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Nombre).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Peso).HasColumnType("float");
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Costo).HasColumnType("money");
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Precio).HasColumnType("money");
            modelBuilder.Entity<Entidades.Producto>().Property(p => p.Ean).HasColumnType("int");
            modelBuilder.Entity<Entidades.Producto>().ToTable("Producto");

            //TablaVendedor
            modelBuilder.Entity<Entidades.Vendedor>().HasKey(v => v.IdVendedor);
            modelBuilder.Entity<Entidades.Vendedor>().HasMany(v => v.Ventas).WithRequired().HasForeignKey(v => v.VendedorId);
            modelBuilder.Entity<Entidades.Vendedor>().HasMany(v => v.Clientes).WithRequired().HasForeignKey(v => v.VendedorId);
            modelBuilder.Entity<Entidades.Vendedor>().Property(v => v.Nombre).HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Vendedor>().Property(v => v.Telefono).HasColumnType("int");
            modelBuilder.Entity<Entidades.Vendedor>().Property(v => v.ZonaId).HasColumnType("int");
            modelBuilder.Entity<Entidades.Vendedor>().ToTable("Vendedor");

            //TablaDetalleVenta
            modelBuilder.Entity<Entidades.DetalleVenta>().HasKey(d => new { d.VentaId, d.ProductoId });
            modelBuilder.Entity<Entidades.DetalleVenta>().HasRequired(d => d.Producto).WithMany().HasForeignKey(d => d.ProductoId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.DetalleVenta>().HasRequired(d => d.Venta).WithMany().HasForeignKey(d => d.VentaId).WillCascadeOnDelete(true);
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Cantidad).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Precio).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Costo).IsRequired().HasColumnType("money");
            modelBuilder.Entity<Entidades.DetalleVenta>().Property(d => d.Peso).IsRequired().HasColumnType("float");
            modelBuilder.Entity<Entidades.DetalleVenta>().ToTable("DetalleVenta");

            //TablaZona
            modelBuilder.Entity<Entidades.Zona>().HasKey(z => z.IdZona);
            modelBuilder.Entity<Entidades.Zona>().HasMany(z => z.Vendedores).WithRequired().HasForeignKey(z => z.ZonaId);
            modelBuilder.Entity<Entidades.Zona>().HasMany(z => z.Clientes).WithRequired().HasForeignKey(z => z.ZonaId);
            modelBuilder.Entity<Entidades.Zona>().Property(z => z.Nombre).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Entidades.Zona>().ToTable("Zona");
        }
    }
}
