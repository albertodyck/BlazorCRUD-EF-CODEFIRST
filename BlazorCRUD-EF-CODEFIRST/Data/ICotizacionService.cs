using BlazorCRUD_EF_CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Data
{
    interface ICotizacionService
    {
        Task<IEnumerable<Cotizacion>> GetAllCotizacion();

        Task<Cotizacion> GetCotizacionDetails(int cotizacionId);

        Task<bool> InsertCotizacion(Cotizacion cotizacion);

        Task<bool> UpdateCotizacion(Cotizacion cotizacion);

        Task<bool> DeleteCotizacion(int cotizacionId);

        Task<bool> SaveCotizacion(Cotizacion cotizacion);
    }
}
