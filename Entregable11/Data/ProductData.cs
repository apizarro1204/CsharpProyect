using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Entregable11.Entities
{
    public static class ProductoData
    {
        // Obtener un producto por su ID
        public static Product ObtenerProducto(int id)
        {
            using (var context = new MiDbContext())
            {
                return context.Productos.Find(id);
            }
        }

        // Listar todos los productos
        public static List<Product> ListarProductos()
        {
            using (var context = new MiDbContext())
            {
                return context.Productos.ToList();
            }
        }

        // Crear un nuevo producto
        public static void CrearProducto(Product producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            using (var context = new MiDbContext())
            {
                context.Productos.Add(producto);
                context.SaveChanges();
            }
        }

        // Modificar un producto existente
        public static void ModificarProducto(Product producto)
        {
            if (producto == null)
                throw new ArgumentNullException(nameof(producto));

            using (var context = new MiDbContext())
            {
                context.Entry(producto).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        // Eliminar un producto por su ID
        public static void EliminarProducto(int id)
        {
            using (var context = new MiDbContext())
            {
                var producto = context.Productos.Find(id);
                if (producto != null)
                {
                    context.Productos.Remove(producto);
                    context.SaveChanges();
                }
            }
        }
    }
}
