namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Commands.CrearUsuarioTrabajador
{
    public class CrearUsuarioTrabajadorModel
    {
        public string Nombre { get; set; } = null!; 

        public string Apellido { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public string Password { get; set; } = null!;

        public int IdRoles { get; set; } 
    }
}
