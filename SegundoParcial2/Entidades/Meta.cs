using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial2.Entidades
{
    public class Meta
    {
        [Key]
        public int idMeta { get; set; }
        public string  descripcion { get; set; }
        public double cuota { get; set; }

        public Meta()
        {
            idMeta = 0;
            descripcion = string.Empty;
            cuota = 0;

        }
        public Meta(int id, string descricion, Double cuota) {
            this.idMeta =id;
            this.descripcion =descripcion;
           this.cuota = cuota;

        }
    }
}
