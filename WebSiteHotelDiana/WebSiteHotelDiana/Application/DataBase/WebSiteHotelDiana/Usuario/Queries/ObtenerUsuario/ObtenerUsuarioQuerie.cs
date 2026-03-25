using Microsoft.EntityFrameworkCore;

namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Queries.ObtenerUsuario
{
    public class ObtenerUsuarioQuerie(IWebSiteHotelDianaDbContext db) : IObtenerUsuarioQuiere
    {
        private readonly IWebSiteHotelDianaDbContext _db = db;
        public async Task<List<ObtenerUsuarioModel>> ExecuteAsync()
        {
            try
            {
                var usuario = await _db.Usuarios
                    .Include(u => u.IdUsuario == IdUsuario)
                    .Select(u => new ObtenerUsuarioModel
                    {
                        IdUsuario = u.IdUsuario,
                        Nombre = u.Nombre,
                        Apellido = u.Apellido,
                        CorreoElectronico = u.CorreoElectronico,
                        IdRoles = u.IdRoles
                    })
                    .ToListAsync();

                return usuario;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}