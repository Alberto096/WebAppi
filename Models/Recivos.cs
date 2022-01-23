using System;
using System.ComponentModel.DataAnnotations;

namespace WebAppi.Models
{
    public class Recivos
    {
        [Key]
        public Guid Id { get; set; }
        public string Proveedor { get; set; }
        public double Monto { get; set; }
        public string Moneda { get; set; }
        public string Comentario { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
