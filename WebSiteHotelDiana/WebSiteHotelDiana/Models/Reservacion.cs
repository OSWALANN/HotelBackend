using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class Reservacion
    {
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public string Automovil { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int NumPersonas { get; set; }

        public int NumNinos { get; set; }

        public int NumMascotas { get; set; }

        public DateOnly FechaCreacion { get; set; }

        public int IdEstadosReservacion { get; set; }


        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }


    }
}