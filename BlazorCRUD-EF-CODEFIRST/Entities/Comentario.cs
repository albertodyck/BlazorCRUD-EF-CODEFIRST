using BlazorCRUD_EF_CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Entities
{
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }

        [Required, Column(TypeName = "varchar(max)")]
        public string Mensaje { get; set; }



        //Relacionar....
        //Llave foranea
        public int CotizacionId { get; set; }
        //Navegacion
        public Cotizacion Cotizacion { get; set; }
    }
}
