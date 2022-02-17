using BlazorCRUD_EF_CODEFIRST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Data
{
    interface IProductoService
    {
		Task<IEnumerable<Producto>> GetAllProductos();

		Task<Producto> GetProductoDetails(int productoId);

		Task<bool> InsertProducto(Producto producto);

		Task<bool> UpdateProducto(Producto producto);

		Task<bool> DeleteProducto(int productoId);

		Task<bool> SaveProducto(Producto producto);
	}
}
