namespace WebSiteHotelDiana.External.Token.Create.Usuario {
    public interface IGetTokenJwtService
    {
        string GenerarTokenUsuario(string IdUsuario, string correo, string nombre, string rol);
    }

}
