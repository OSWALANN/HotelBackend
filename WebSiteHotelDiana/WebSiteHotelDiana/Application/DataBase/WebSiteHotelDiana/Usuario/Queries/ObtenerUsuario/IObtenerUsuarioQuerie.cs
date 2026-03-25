namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Queries.ObtenerUsuario
{
    public interface IObtenerUsuarioQuiere
    {
        Task<List<ObtenerUsuarioModel>> ExecuteAsync();
    }
}
