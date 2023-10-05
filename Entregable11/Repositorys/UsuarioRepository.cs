using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entregable11.Entities;
using System;

namespace Entregable11.Repositorys
{
    public class UsuarioRepository
    {
        private readonly MiDbContext _context;

        public UsuarioRepository(MiDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AgregarUsuario(User usuario)
        {
            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // Agrega más métodos para realizar operaciones de acceso a datos relacionadas con usuarios si es necesario.
    }
}
