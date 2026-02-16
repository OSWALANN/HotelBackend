namespace WebSiteHotelDiana.Models
{
    public class DetallesReservacionModel
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
        public virtual HabitacionModel Habitacion { get; set; } = null!;

        public virtual ReservacionModel Reservacion { get; set; } = null!;

        public virtual EstadosOperativosHabitacionModel EstadosOperativosHabitacion { get; set; } = null!;

    }
}