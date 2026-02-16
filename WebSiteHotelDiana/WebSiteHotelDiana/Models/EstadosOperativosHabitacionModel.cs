using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class EstadosOperativosHabitacionModel
    {
       public int IdEstadosOperativosHabitacion { get; set; }
        public string TiposEstadosOperativosHabitacion { get; set; }

        public bool BloqueaInventario { get; set; }

        public virtual ICollection<DetallesReservacionModel> DetallesReservacion { get; set; } = new List<DetallesReservacionModel>();
    }
}