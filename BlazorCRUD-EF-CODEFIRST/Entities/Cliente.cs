using BlazorCRUD_EF_CODEFIRST.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD_EF_CODEFIRST.Entities
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        public string NombreCliente { get; set; }

        public string Contacto { get; set; }

        [Required, EmailAddress, StringLength(maximumLength: 250), Column(TypeName = "varchar(250)")]
        public string Email { get; set; }

        [StringLength(maximumLength: 20), Column(TypeName = "varchar(20)")]
        public string TelefonoContacto { get; set; }

        public int CotizacionId { get; set; }

        public Cotizacion Cotizacion { get; set; }


    }
}
