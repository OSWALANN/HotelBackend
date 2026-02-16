using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class UsuariosModel
    {
        public int IdUsuario { get; set; }
         public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string CorreoElectronico { get; set; }

        public string PasswordHash { get; set; }

        public int IdRoles { get; set; }

        public virtual RolesModel Roles { get; set; } = null!;

        public virtual ICollection<ReservacionModel> Reservacion { get; set; } = new List<ReservacionModel>();


    }
}