using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace SegundoParcial2.Entidades
{
   
    public class DetalleVendedor
    {
        [Key]
        public int DetalleVendedorId { get; set; }

        public int idMeta { get; set; }

        public int IdMetas { get; set; }

        public Double cuotass { get; set; }

        public Double cuota { get; set; }

        public DetalleVendedor()
        {
            DetalleVendedorId = 0;
            idMeta = 0;
            IdMetas = 00;
            cuota = 0;
            cuotass = 0;
        }
        public DetalleVendedor(int id, int idmetas, int Idmeta, Double couta)
        {
            this.DetalleVendedorId = id;
            this.idMeta = idmetas;
            this.IdMetas = Idmeta;
            this.cuota = couta;
           
            //this.Total = total;
        }

    }
}
