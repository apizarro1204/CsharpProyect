using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entregable11.Entities
{
    public static class VentaData
    {
        // Obtener una venta por su ID
        public static Sales ObtenerVenta(int id)
        {
            using (var context = new MiDbContext())
            {
                return context.Ventas.Find(id);
            }
        }

        // Listar todas las ventas
        public static List<Sales> ListarVentas()
        {
            using (var context = new MiDbContext())
            {
                return context.Ventas.ToList();
            }
        }

        // Crear una nueva venta
        public static void CrearVenta(Sales venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            using (var context = new MiDbContext())
            {
                context.Ventas.Add(venta);
                context.SaveChanges();
            }
        }

        // Modificar una venta existente
        public static void ModificarVenta(Sales venta)
        {
            if (venta == null)
                throw new ArgumentNullException(nameof(venta));

            using (var context = new MiDbContext())
            {
                context.Entry(venta).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        // Eliminar una venta por su ID
        public static void EliminarVenta(int id)
        {
            using (var context = new MiDbContext())
            {
                var venta = context.Ventas.Find(id);
                if (venta != null)
                {
                    context.Ventas.Remove(venta);
                    context.SaveChanges();
                }
            }
        }
    }
}
