using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Parcial.Models
{
    [Table("t_conversion")]
    public class Conversion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal? Monto { get; set; }
        public string? MonedaOrigen { get; set; }

    }
}