using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    }
}
