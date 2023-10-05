using System.Data.Entity;

namespace Entregable11.Entities
{
    public class DataInitializer : CreateDatabaseIfNotExists<MiDbContext>
    {
        protected override void Seed(MiDbContext context)
        {
            // Agregar datos ficticios de usuarios
            context.Usuarios.Add(new User
            {
                Nombre = "Juan",
                Apellido = "Pérez",
                NombreUsuario = "juanperez",
                Contraseña = "clave123",
                Mail = "juan@example.com"
            });

            context.Usuarios.Add(new User
            {
                Nombre = "María",
                Apellido = "Gómez",
                NombreUsuario = "mariagomez",
                Contraseña = "password456",
                Mail = "maria@example.com"
            });

            // Agregar más datos ficticios si es necesario

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
