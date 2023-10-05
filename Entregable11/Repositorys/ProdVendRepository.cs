using Entregable11.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable11.Repositorys
{
     public class ProdVendRepository
    {
        private readonly MiDbContext _context;

        public ProdVendRepository(MiDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AgregarProducto(ProductSold productoVendido)
        {
            if (productoVendido == null)
                throw new ArgumentNullException(nameof(productoVendido));

            _context.ProductosVendidos.Add(productoVendido);
            _context.SaveChanges();
        }

        // Agrega más métodos para realizar operaciones de acceso a datos relacionadas con productos si es necesario.
    }
}
