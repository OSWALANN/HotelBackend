using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class HabitacionModel
    {
        public int IdHabitacion { get; set; }
        public int IdEstadosHabitacion { get; set; }
        public string descripcion { get; set; }

        public int CapacidadAdultos { get; set; }

        public int CapicidadNinos { get; set; }

        public bool PermiteMascotas { get; set; }

        public DateOnly FechaRegistroHabitacion { get; set; }

        public string foto { get; set; }
       
       public virtual EstadosHabitacionModel EstadosHabitacion { get; set; } = null!;
        public virtual ICollection<DetallesReservacionModel> DetallesReservacion { get; set; } = new List<DetallesReservacionModel>();
        public virtual ICollection<PrecioTemporalModel> PrecioTemporal { get; set; } = new List<PrecioTemporalModel>();
    }
}