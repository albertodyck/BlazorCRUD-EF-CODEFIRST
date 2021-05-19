using BlazorCRUD_EF_CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorCRUD_EF_CODEFIRST.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorCRUD_EF_CODEFIRST.Data
{
    public class CotizacionService : ICotizacionService
    {
        private readonly CotizacionDbContext _context;

        public CotizacionService(CotizacionDbContext context)
        {
            _context = context;
        }


        public async Task<bool> DeleteCotizacion(int cotizacionId)
        {
            var cotizacion = await _context.Cotizaciones.FindAsync(cotizacionId);

            _context.Cotizaciones.Remove(cotizacion);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Cotizacion>> GetAllCotizacion()
        {
            return await _context.Cotizaciones.ToListAsync();
        }

        public async Task<Cotizacion> GetCotizacionDetails(int cotizacionId)
        {
            return await _context.Cotizaciones.FindAsync(cotizacionId);
        }

        public async Task<bool> InsertCotizacion(Cotizacion cotizacion)
        {
            _context.Cotizaciones.Add(cotizacion);

            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> SaveCotizacion(Cotizacion cotizacion)
        {
            //servicio decide cuando llamar insert o update, nosotros solo usaremos SaveCotizacion, los dos no se usaran desde afuera

            if (cotizacion.CotizacionId > 0)
            {
                //la cotizacion existe
                return await UpdateCotizacion(cotizacion);
            }
            else
            {
                //es nuevo no existe
                return await InsertCotizacion(cotizacion);
            }
        }

        public async Task<bool> UpdateCotizacion(Cotizacion cotizacion)
        {
            _context.Entry(cotizacion).State = EntityState.Modified;

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
