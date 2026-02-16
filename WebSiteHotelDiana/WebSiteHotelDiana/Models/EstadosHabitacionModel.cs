using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class EstadosHabitacionModel
    {
       public int IdEstadosHabitacion { get; set; }
        public string TiposEstados { get; set; }
     
        public virtual ICollection<HabitacionModel> Habitacion { get; set; } = new List<HabitacionModel>();
    }
}