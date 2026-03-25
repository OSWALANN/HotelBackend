using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using WebSiteHotelDiana.Models;
using WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana;


namespace WebSiteHotelDiana.Data;

public partial class WebSiteHotelDianaDbContext : DbContext, IWebSiteHotelDianaDbContext
{
    public WebSiteHotelDianaDbContext(DbContextOptions<WebSiteHotelDianaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UsuariosModel> Usuarios { get; set; }

    public virtual DbSet<RolesModel> Roles { get; set; }

    public virtual DbSet<ReservacionModel> Reservacion { get; set; }

    public virtual DbSet<PrecioTemporalModel> PrecioTemporal { get; set; }

    public virtual DbSet<HabitacionModel> Habitacion { get; set; }

    public virtual DbSet<EstadosReservacionModel> EstadosReservacion { get; set; }

    public virtual DbSet<EstadosOperativosHabitacionModel> EstadosOperativosHabitacion { get; set; }
    public virtual DbSet<EstadosHabitacionModel> EstadosHabitacion { get; set; }

    public virtual DbSet<DetallesReservacionModel> DetallesReservacion { get; set; }


    public async Task<bool> SaveAsync()
    {
        return await SaveChangesAsync() > 0;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("public");

        modelBuilder.Entity<UsuariosModel>(entity =>
        {
            entity.ToTable("usuarios");

            entity.HasKey(e => e.IdUsuario);

            entity.Property(e => e.IdUsuario)
                .HasColumnName("id_usuario");

            entity.Property(e => e.IdRoles)
                .HasColumnName("id_roles");

            entity.Property(e => e.Nombre)
                .HasColumnName("nombre")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.Apellido)
                .HasColumnName("apellido")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.CorreoElectronico)
               .HasColumnName("correo_electronico")
               .HasMaxLength(100)
               .IsRequired();

            entity.Property(e => e.PasswordHash)
               .HasColumnName("contrasenia")
               .HasMaxLength(255)
               .IsRequired();

            entity.HasOne(e => e.Roles)
                .WithMany()
                .HasForeignKey(e => e.IdRoles);
        });

        modelBuilder.Entity<RolesModel>(entity =>
        {
            entity.ToTable("roles");

            entity.HasKey(e => e.IdRoles);

            entity.Property(e => e.IdRoles)
                .HasColumnName("id_roles");

            entity.Property(e => e.TipoRol)
                .HasColumnName("tipo_rol")
                .HasMaxLength(120)
                .IsRequired();

          
        });

        modelBuilder.Entity<EstadosHabitacionModel>(entity =>
        {
            entity.ToTable("estados_habitacion");

            entity.HasKey(e => e.IdEstadosHabitacion);

            entity.Property(e => e.IdEstadosHabitacion)
                .HasColumnName("id_estados_habitacion");

            entity.Property(e => e.TiposEstados)
                .HasColumnName("tipos_estados")
                .HasMaxLength(120)
                .IsRequired();


        });

        modelBuilder.Entity<EstadosOperativosHabitacionModel>(entity =>
        {
            entity.ToTable("estados_operativos_habitacion");

            entity.HasKey(e => e.IdEstadosOperativosHabitacion);

            entity.Property(e => e.IdEstadosOperativosHabitacion)
                .HasColumnName("id_estados_operativos_habitacion");

            entity.Property(e => e.TiposEstadosOperativosHabitacion)
                .HasColumnName("tipos_estados_operativos_habitacion")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.TiposEstadosOperativosHabitacion)
                .HasColumnName("tipos_estados_operativos_habitacion")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.BloqueaInventario)
                .HasColumnName("bloquea_inventario")
                .IsRequired();

        });

        modelBuilder.Entity<PrecioTemporalModel>(entity =>
        {
            entity.ToTable("precio_temporal");
            entity.HasKey(e => e.IdPrecioTemporal);
            entity.Property(e => e.IdPrecioTemporal)
                .HasColumnName("id_precio_temporal");
            entity.Property(e => e.Precio)
                .HasColumnName("precio")
                .HasColumnType("decimal(18,2)")
                .IsRequired();
            entity.Property(e => e.FechaInicio)
                .HasColumnName("fecha_inicio")
                .HasColumnType("date")
                .IsRequired();
            entity.Property(e => e.FechaFin)
                .HasColumnName("fecha_fin")
                .HasColumnType("date")
                .IsRequired();
        });

        modelBuilder.Entity<ReservacionModel>(entity =>
        {
            entity.ToTable("reservacion");
            entity.HasKey(e => e.IdReserva);
            entity.Property(e => e.IdReserva)
                .HasColumnName("id_reserva");
            entity.Property(e => e.IdUsuario)
                .HasColumnName("id_usuario");
            entity.Property(e => e.IdEstadosReservacion)
                .HasColumnName("id_estados_reservacion");


            entity.Property(e => e.NumMascotas)
                .HasColumnName("num_mascotas")
                .IsRequired();

            entity.Property(e => e.NumPersonas)
               .HasColumnName("num_personas")
               .IsRequired();

            entity.Property(e => e.NumNinos)
               .HasColumnName("num_ninos")
               .IsRequired();

            entity.Property(e => e.NombreHuesped)
                .HasColumnName("nombre_huesped")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.CorreoHuesped)
               .HasColumnName("correo_huesped")
               .HasMaxLength(120)
               .IsRequired();

            entity.Property(e => e.ApellidoHuesped)
                .HasColumnName("apellido_huesped")
                .HasMaxLength(120)
                .IsRequired();

             entity.Property(e => e.Automovil)
                .HasColumnName("automovil")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.Telefono)
                .HasColumnName("telefono")
                .HasMaxLength(120)
                .IsRequired();

            entity.Property(e => e.FechaCreacion)
                .HasColumnName("fecha_reserva")
                .HasColumnType("date")
                .IsRequired();

            entity.HasOne(e => e.Usuarios)
                .WithMany()
                .HasForeignKey(e => e.IdUsuario);

            entity.HasOne(e => e.EstadosReservacion)
                .WithMany()
                .HasForeignKey(e => e.IdEstadosReservacion);
        });

        modelBuilder.Entity<DetallesReservacionModel>(entity =>
        {
            entity.ToTable("detalles_reservacion");

            entity.HasKey(e => e.IdDetallesReservacion);

            entity.Property(e => e.IdDetallesReservacion)
                .HasColumnName("id_detalles_reservacion");

            entity.Property(e => e.IdHabitacion)
                .HasColumnName("id_habitacion");

            entity.Property(e => e.IdReserva)
                .HasColumnName("id_reserva");

            entity.Property(e => e.IdEstadosOperativosHabitacion)
                .HasColumnName("id_estados_operativos_habitacion");
           
            entity.Property(e => e.Precioxnoche)
                .HasColumnName("precioxnoche")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            entity.Property(e => e.FechaInicio)
                .HasColumnName("fecha_inicio")
                .HasColumnType("date")
                .IsRequired();

            entity.Property(e => e.FechaFin)
                .HasColumnName("fecha_fin")
                .HasColumnType("date")
                .IsRequired();

            entity.Property(e => e.BloqueaInventario)
                .HasColumnName("bloquea_inventario")
                .IsRequired();

            entity.HasOne(e => e.Habitacion)
                .WithMany()
                .HasForeignKey(e => e.IdHabitacion);

            entity.HasOne(e => e.Reservacion)
                .WithMany()
                .HasForeignKey(e => e.IdReserva);

            entity.HasOne(e => e.EstadosOperativosHabitacion)
               .WithMany()
               .HasForeignKey(e => e.IdEstadosOperativosHabitacion);
        }); 


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
