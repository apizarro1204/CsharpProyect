using Entregable11.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable11.Repositorys
{
    public class VentasRepository
    {
        private readonly MiDbContext _context;

        public VentasRepository(MiDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AgregarProducto(Sales venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            _context.Ventas.Add(venta);
            _context.SaveChanges();
        }

        // Agrega más métodos para realizar operaciones de acceso a datos relacionadas con productos si es necesario.
    }
}
