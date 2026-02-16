using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using WebSiteHotelDiana.Models;


namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana
{
    public interface IWebSiteHotelDianaDbContext
    {
        DbSet<UsuariosModel> Usuarios { get; set; }

        DbSet<RolesModel> Roles { get; set; }

        DbSet<ReservacionModel> Reservacion { get; set; }

        DbSet<PrecioTemporalModel> PrecioTemporal { get; set; }

        DbSet<HabitacionModel> Habitacion { get; set; }

        DbSet<EstadosReservacionModel> EstadosReservacion { get; set; }

        DbSet<EstadosOperativosHabitacionModel> EstadosOperativosHabitacion { get; set; }

        DbSet<EstadosHabitacionModel> EstadosHabitacion { get; set; }

        DbSet<DetallesReservacionModel> DetallesReservacion { get; set; }
        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        Task<bool> SaveAsync();
    }
}
