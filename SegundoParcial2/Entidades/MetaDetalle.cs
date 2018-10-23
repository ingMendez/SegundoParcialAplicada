using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial2.Entidades
{
   public class MetaDetalle
    {
        [Key]
        public int IdMetas { get; set; }
        public int VendedorId { get; set; }
        public double Cuota { get; set; }
        //public  MyProperty { get; set; }

    }
}
