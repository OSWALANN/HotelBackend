
namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Commands.CrearUsuarioTrabajador
{
    public interface ICrearUsuarioTrabajadorCommand
    {
          
        Task<bool> ExecuteAsync(CrearUsuarioTrabajadorModel model);
}
}
