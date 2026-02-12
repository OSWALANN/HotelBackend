namespace WebSiteHotelDiana.Models
{
    public class DetallesReservacion
    {
        public int IdDetallesReservacion { get; set; }
        public int IdHabitacion { get; set; }
        public int IdReserva { get; set; }
        public int IdEstadosOperativosHabitacion { get; set; }
        public decimal Precioxnoche { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool BloqueaInventario { get; set; }
        // Navigation properties
        /*public virtual Habitacion Habitacion { get; set; } = null!;
        public virtual DatosDomiciliario DatosDomiciliarios { get; set; } = null!;
        public virtual ICollection<Documento> Documentos { get; set; }
            = new List<Documento>();
        public virtual ICollection<Bitacora> Bitacoras { get; set; }
            = new List<Bitacora>();*/
    }
}