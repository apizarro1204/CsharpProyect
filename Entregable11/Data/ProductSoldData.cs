using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entregable11.Entities
{
    public static class ProductoVendidoData
    {
        // Obtener un producto vendido por su ID
        public static ProductSold ObtenerProductoVendido(int id)
        {
            using (var context = new MiDbContext())
            {
                return context.ProductosVendidos.Find(id);
            }
        }

        // Listar todos los productos vendidos
        public static List<ProductSold> ListarProductosVendidos()
        {
            using (var context = new MiDbContext())
            {
                return context.ProductosVendidos.ToList();
            }
        }

        // Crear un nuevo producto vendido
        public static void CrearProductoVendido(ProductSold productoVendido)
        {
            if (productoVendido == null)
                throw new ArgumentNullException(nameof(productoVendido));

            using (var context = new MiDbContext())
            {
                context.ProductosVendidos.Add(productoVendido);
                context.SaveChanges();
            }
        }

        // Modificar un producto vendido existente
        public static void ModificarProductoVendido(ProductSold productoVendido)
        {
            if (productoVendido == null)
                throw new ArgumentNullException(nameof(productoVendido));

            using (var context = new MiDbContext())
            {
                context.Entry(productoVendido).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        // Eliminar un producto vendido por su ID
        public static void EliminarProductoVendido(int id)
        {
            using (var context = new MiDbContext())
            {
                var productoVendido = context.ProductosVendidos.Find(id);
                if (productoVendido != null)
                {
                    context.ProductosVendidos.Remove(productoVendido);
                    context.SaveChanges();
                }
            }
        }
    }
}
