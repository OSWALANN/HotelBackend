namespace   WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Commands.CrearUsuario
{
    public interface ICrearUsuarioCommand
    {
        Task<bool> ExecuteAsync(CrearUsuarioModel model);
    }

}
