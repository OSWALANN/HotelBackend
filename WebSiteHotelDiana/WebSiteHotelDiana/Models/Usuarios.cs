using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
         public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string CorreoElectronico { get; set; }

        public string Contrasenia { get; set; }

        public int IdRoles { get; set; }
    }
}