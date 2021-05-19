using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Entities
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }

        public int Cantidad { get; set; }

        public string Descripcion { get; set; }

        public int SKU { get; set; }

        public decimal PrecioUnitario { get; set; }

        public decimal TotalFila { get; set; }

        public int CotizacionId { get; set; }

    }
}
