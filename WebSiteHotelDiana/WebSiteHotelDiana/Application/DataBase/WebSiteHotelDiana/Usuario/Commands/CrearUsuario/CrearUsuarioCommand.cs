using Microsoft.EntityFrameworkCore;
using WSTarjetaJuventud.Helpers;
using WebSiteHotelDiana.Models;
namespace WebSiteHotelDiana.Application.DataBase.WebSiteHotelDiana.Usuario.Commands.CrearUsuario 
{ 
    public class CrearUsuarioCommand : ICrearUsuarioCommand 
    {
        private readonly IWebSiteHotelDianaDbContext _context; 
        public CrearUsuarioCommand(IWebSiteHotelDianaDbContext context) { _context = context; } 
        public async Task<bool> ExecuteAsync(CrearUsuarioModel model) 
        { 
            try 
            { 
                var correo = model.Correo.Trim().ToLower(); 
                var usuarioExistente = await _context.Usuarios.FirstOrDefaultAsync(u => u.CorreoElectronico.ToLower() == correo); 
                if (usuarioExistente != null) { return false; 
                } 
                var nuevoUsuario = new UsuariosModel 
                { 
                    Nombre = model.Nombre, 
                    Apellido = model.Apellido, 
                    CorreoElectronico = correo, 
                    PasswordHash = PasswordHasher.HashPassword(model.Password), 
                    IdRoles = 1 }; 
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
