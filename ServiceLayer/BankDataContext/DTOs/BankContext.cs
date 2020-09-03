namespace ServiceLayer.BankDataContext.DTOs
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BankContext : DbContext
    {
        public BankContext()
            : base("name=BankContext")
        {
        }

        public virtual DbSet<Agencia> Agencia { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cuentas> Cuentas { get; set; }
        public virtual DbSet<Empleados> Empleados { get; set; }
        public virtual DbSet<Permisos> Permisos { get; set; }
        public virtual DbSet<TipoOperacion> TipoOperacion { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Agencia>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Agencia>()
                .HasMany(e => e.Empleados)
                .WithRequired(e => e.Agencia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Bancos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Bancos>()
                .HasMany(e => e.Agencia)
                .WithRequired(e => e.Bancos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.NoCedula)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.EstadoCivil)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .HasMany(e => e.Transacciones)
                .WithRequired(e => e.Clientes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuentas>()
                .Property(e => e.NoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Cuentas>()
                .Property(e => e.SaldoApertura)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Cuentas>()
                .Property(e => e.Saldo)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Cuentas>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.NoCedula)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Empleados>()
                .HasMany(e => e.Transacciones)
                .WithRequired(e => e.Empleados)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Permisos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .HasMany(e => e.Transacciones)
                .WithRequired(e => e.TipoOperacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transacciones>()
                .Property(e => e.Saldo_Anterior)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Transacciones>()
                .Property(e => e.Importe)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Transacciones>()
                .Property(e => e.Saldo_Nuevo)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Empleados)
                .WithRequired(e => e.Usuarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuarios>()
                .HasMany(e => e.Permisos)
                .WithRequired(e => e.Usuarios)
                .WillCascadeOnDelete(false);
        }
    }
}
