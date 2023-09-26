using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CyberGear16.Models;

public partial class BdCybergearContext : DbContext
{
    public BdCybergearContext()
    {
    }

    public BdCybergearContext(DbContextOptions<BdCybergearContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Domicilio> Domicilios { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<TiposUsuario> TiposUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VentasCabecera> VentasCabeceras { get; set; }

    public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=bd_cybergear;uid=root;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.27-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.Dni, "dni").IsUnique();

            entity.HasIndex(e => e.DomicilioId, "domicilio_id");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .HasColumnName("apellido");
            entity.Property(e => e.Baja)
                .HasMaxLength(2)
                .HasDefaultValueSql("'NO'")
                .HasColumnName("baja");
            entity.Property(e => e.Dni)
                .HasColumnType("int(11)")
                .HasColumnName("dni");
            entity.Property(e => e.DomicilioId)
                .HasColumnType("int(11)")
                .HasColumnName("domicilio_id");
            entity.Property(e => e.Email)
                .HasMaxLength(40)
                .HasColumnName("email");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .HasColumnName("nombre");
            entity.Property(e => e.Sexo)
                .HasMaxLength(20)
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasColumnType("bigint(15)")
                .HasColumnName("telefono");

            entity.HasOne(d => d.Domicilio).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.DomicilioId)
                .HasConstraintName("clientes_ibfk_2");
        });

        modelBuilder.Entity<Domicilio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("domicilios");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CodPostal)
                .HasColumnType("int(255)")
                .HasColumnName("cod_postal");
            entity.Property(e => e.Direccion)
                .HasMaxLength(40)
                .HasColumnName("direccion");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("products");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Activo)
                .HasMaxLength(2)
                .HasDefaultValueSql("'SI'")
                .HasColumnName("activo");
            entity.Property(e => e.Cantidad)
                .HasColumnType("int(100)")
                .HasColumnName("cantidad");
            entity.Property(e => e.CategoriaId)
                .HasColumnType("int(2)")
                .HasColumnName("categoria_id");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(255)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.PrecioProducto)
                .HasColumnType("double(16,2)")
                .HasColumnName("precio_producto");
        });

        modelBuilder.Entity<TiposUsuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipos_usuario");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuarios");

            entity.HasIndex(e => e.DomicilioId, "domicilio_id");

            entity.HasIndex(e => new { e.Email, e.Usuario1 }, "email").IsUnique();

            entity.HasIndex(e => e.PerfilId, "perfil_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Apellido)
                .HasMaxLength(30)
                .HasColumnName("apellido");
            entity.Property(e => e.Baja)
                .HasMaxLength(2)
                .HasDefaultValueSql("'NO'")
                .HasColumnName("baja");
            entity.Property(e => e.Dni)
                .HasColumnType("int(30)")
                .HasColumnName("dni");
            entity.Property(e => e.DomicilioId)
                .HasColumnType("int(11)")
                .HasColumnName("domicilio_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .HasColumnName("nombre");
            entity.Property(e => e.Pass)
                .HasMaxLength(50)
                .HasColumnName("pass");
            entity.Property(e => e.PerfilId)
                .HasDefaultValueSql("'2'")
                .HasColumnType("int(11)")
                .HasColumnName("perfil_id");
            entity.Property(e => e.Sexo)
                .HasMaxLength(10)
                .HasColumnName("sexo");
            entity.Property(e => e.Tel)
                .HasColumnType("bigint(15)")
                .HasColumnName("tel");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .HasColumnName("usuario");

            entity.HasOne(d => d.Domicilio).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.DomicilioId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("usuarios_ibfk_2");

            entity.HasOne(d => d.Perfil).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.PerfilId)
                .HasConstraintName("usuarios_ibfk_3");
        });

        modelBuilder.Entity<VentasCabecera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ventas_cabecera");

            entity.HasIndex(e => e.IdCliente, "id_cliente");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdCliente)
                .HasColumnType("int(11)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.TotalVenta).HasColumnName("total_venta");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.VentasCabeceras)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("ventas_cabecera_ibfk_1");
        });

        modelBuilder.Entity<VentasDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ventas_detalle");

            entity.HasIndex(e => e.ProductoId, "producto_id");

            entity.HasIndex(e => new { e.VentaId, e.ProductoId }, "venta_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CantidadVenta)
                .HasColumnType("int(11)")
                .HasColumnName("cantidad_venta");
            entity.Property(e => e.Precio).HasColumnName("precio");
            entity.Property(e => e.ProductoId)
                .HasColumnType("int(11)")
                .HasColumnName("producto_id");
            entity.Property(e => e.SubTotal).HasColumnName("sub_total");
            entity.Property(e => e.VentaId)
                .HasColumnType("int(11)")
                .HasColumnName("venta_id");

            entity.HasOne(d => d.Producto).WithMany(p => p.VentasDetalles)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("ventas_detalle_ibfk_1");

            entity.HasOne(d => d.Venta).WithMany(p => p.VentasDetalles)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("ventas_detalle_ibfk_2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
