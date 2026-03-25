
namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Queries.ObtenerUsuario
{
    public class ObtenerUsuarioModel
    {
        public int IdUsuario { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string CorreoElectronico { get; set; } = null!;

        public bool IdRoles { get; set; }


    }
}
