using BlazorCRUD_EF_CODEFIRST.Entities;
using BlazorCRUD_EF_CODEFIRST.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Context
{
    public class CotizacionDbContext : DbContext
    {
        public CotizacionDbContext()
        {
        }

        //recibimos las opciones al generar la clase, eliminamos dependencias
        public CotizacionDbContext(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelbuilder)
        //{
        //    new CotizacionEntityTypeConfiguration().Configure(modelbuilder.Entity<Cotizacion>());

        //    base.OnModelCreating(modelbuilder);
        //}


        //creamos la tabla Cotizaciones con la entidad cotizacion
        public DbSet<Cotizacion> Cotizaciones{ get; set; }

        public DbSet<Comentario> Comentarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Producto> Productos { get; set; }



    }
}
