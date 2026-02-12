using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class Habitacion
    {
        public int IdHabitacion { get; set; }
        public int IdEstadosHabitacion { get; set; }
        public string descripcion { get; set; }

        public int CapacidadAdultos { get; set; }

        public int CapicidadNinos { get; set; }

        public bool PermiteMascotas { get; set; }

        public DateOnly FechaRegistroHabitacion { get; set; }

        public string foto { get; set; }
       
       
    }
}