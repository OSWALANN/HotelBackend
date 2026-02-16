using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class ReservacionModel
    {
        public int IdReserva { get; set; }

        public int IdUsuario { get; set; }

        public int IdEstadosReservacion { get; set; }

        public string Automovil { get; set; }

        public string Telefono { get; set; }
        public string NombreHuesped { get; set; }

        public string CorreoHuesped { get; set; }
        public string ApellidoHuesped { get; set; }

        public int NumPersonas { get; set; }

        public int NumNinos { get; set; }

        public int NumMascotas { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual UsuariosModel Usuarios { get; set; } = null!;

        public virtual EstadosReservacionModel EstadosReservacion { get; set; } = null!;

        public virtual ReservacionModel Reservacion { get; set; } = null!;

    }
}