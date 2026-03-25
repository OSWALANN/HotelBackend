using global::WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Commands.CrearUsuario;
using global::WebSiteHotelDiana.Models;
using Microsoft.EntityFrameworkCore;
using WebSiteHotelDiana.Models;
using WSTarjetaJuventud.Helpers;

namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Commands.CrearUsuarioTrabajador

{
    public class CrearUsuarioTrabajadorCommand : ICrearUsuarioTrabajadorCommand
    {
        private readonly IWebSiteHotelDianaDbContext _context;
        public CrearUsuarioTrabajadorCommand(IWebSiteHotelDianaDbContext context) { _context = context; }
        public async Task<bool> ExecuteAsync(CrearUsuarioTrabajadorModel model)
        {
            try
            {
                var correo = model.Correo.Trim().ToLower();
                var usuarioExistente = await _context.Usuarios.FirstOrDefaultAsync(u => u.CorreoElectronico.ToLower() == correo);
                if (usuarioExistente != null)
                {
                    return false;
                }
                var nuevoUsuario = new UsuariosModel
                {
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    CorreoElectronico = correo,
                    PasswordHash = PasswordHasher.HashPassword(model.Password),
                    IdRoles = model.IdRoles
                };
                _context.Usuarios.Add(nuevoUsuario);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
