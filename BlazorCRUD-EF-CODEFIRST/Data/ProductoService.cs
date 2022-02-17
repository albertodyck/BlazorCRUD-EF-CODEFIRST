using BlazorCRUD_EF_CODEFIRST.Context;
using BlazorCRUD_EF_CODEFIRST.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Data
{
    public class ProductoService : IProductoService
    {
        private readonly CotizacionDbContext _context;

        public ProductoService(CotizacionDbContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteProducto(int ProductoId)
        {
            var producto = await _context.Productos.FindAsync(ProductoId);

            _context.Productos.Remove(producto);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Producto>> GetAllProductos()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto> GetProductoDetails(int productoId)
        {
            return await _context.Productos.FindAsync(productoId);
        }

        public async Task<bool> InsertProducto(Producto producto)
        {
            _context.Productos.Add(producto);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveProducto(Producto producto)
        {
            if (producto.ProductoId > 0)
            {
                return await UpdateProducto(producto);
            }
            else
            {
                return await InsertProducto(producto);
            }
        }

        public async Task<bool> UpdateProducto(Producto producto)
        {
            _context.Entry(producto).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
