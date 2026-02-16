using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class PrecioTemporalModel
    {
        public int IdPrecioTemporal { get; set; }
        public int IdHabitacion { get; set; }
        public decimal Precio { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

       public virtual HabitacionModel Habitacion { get; set; } = null!;


    }
}