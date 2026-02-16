using System.Runtime.CompilerServices;

namespace WebSiteHotelDiana.Models
{
    public class RolesModel
    {
        public int IdRoles { get; set; }
        public string TipoRol { get; set; }
        

        public virtual ICollection<UsuariosModel> Usuarios { get; set; } = new List<UsuariosModel>();
    }
}