using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CondicionPavMVC.Models;

public partial class CondicionPavDbContext : DbContext
{
    public CondicionPavDbContext()
    {
    }

    public CondicionPavDbContext(DbContextOptions<CondicionPavDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carrile> Carriles { get; set; }

    public virtual DbSet<Proyecto> Proyectos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("workstation id=CondicionPavDB.mssql.somee.com;packet size=4096;user id=StanBMTH_SQLLogin_1;pwd=spkp4cyrue;data source=CondicionPavDB.mssql.somee.com;persist security info=False;initial catalog=CondicionPavDB; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Carrile>(entity =>
        {
            entity.HasKey(e => e.CarrilId);

            entity.Property(e => e.CarrilId).HasColumnName("carrilID");
            entity.Property(e => e.Pavimento)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pavimento");
            entity.Property(e => e.ProyectoId).HasColumnName("proyectoID");
            entity.Property(e => e.TipoCarril)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tipoCarril");
        });

        modelBuilder.Entity<Proyecto>(entity =>
        {
            entity.Property(e => e.ProyectoId).HasColumnName("proyectoID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tramo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("tramo");
            entity.Property(e => e.UsuarioId).HasColumnName("usuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Proyectos)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proyectos_Usuarios");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK_Crendeciales");

            entity.Property(e => e.UserId).HasColumnName("userID");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Clave)
                .HasMaxLength(500)
                .HasColumnName("clave");
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
