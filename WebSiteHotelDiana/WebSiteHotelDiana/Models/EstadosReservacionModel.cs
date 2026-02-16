using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class EstadosReservacionModel
    {
        public int IdEstadosReservacion { get; set; }
        public string TiposEstadosReservacion { get; set; }

        public virtual ICollection<ReservacionModel> Reservacion { get; set; } = new List<ReservacionModel>();

    }
}