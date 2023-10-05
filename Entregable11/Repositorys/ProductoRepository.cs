using Entregable11.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable11.Repositorys
{
    public class ProductoRepository
    {
        private readonly MiDbContext _context;

        public ProductoRepository(MiDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AgregarProducto(Product producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        // Agrega más métodos para realizar operaciones de acceso a datos relacionadas con productos si es necesario.
    }
}
