using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entregable11.Entities;

namespace Entregable11.Data
{
    public static class UsuarioData
    {
        // Obtener un usuario por su ID
        public static User ObtenerUsuario(int id)
        {
            using (var context = new MiDbContext()) 
            {
                return context.Usuarios.Find(id);
            }
        }

        // Listar todos los usuarios
        public static List<User> ListarUsuarios()
        {
            using (var context = new MiDbContext())
            {
                return context.Usuarios.ToList();
            }
        }

        // Crear un nuevo usuario
        public static void CrearUsuario(User usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            using (var context = new MiDbContext())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        // Modificar un usuario existente
        public static void ModificarUsuario(User usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            using (var context = new MiDbContext())
            {
                context.Entry(usuario).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        // Eliminar un usuario por su ID
        public static void EliminarUsuario(int id)
        {
            using (var context = new MiDbContext())
            {
                var usuario = context.Usuarios.Find(id);
                if (usuario != null)
                {
                    context.Usuarios.Remove(usuario);
                    context.SaveChanges();
                }
            }
        }
    }
}
