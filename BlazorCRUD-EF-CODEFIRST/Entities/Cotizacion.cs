using BlazorCRUD_EF_CODEFIRST.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Models
{
    public class Cotizacion
    {
        [Key]
        public int CotizacionId { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? FechaCaptura { get; set; }

        public int TiempoEntrega { get; set; }

        public string Moneda { get; set; }

        public string TerminosPago { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Vigencia { get; set; }

        public decimal SubTotal { get; set; }

        public decimal IVA { get; set; }

        public decimal Total { get; set; }

        public int ClienteId { get; set; }

        public List<Producto> Productos { get; set; }

        public List<Comentario> Comentarios { get; set; }

    }
}
