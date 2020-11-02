using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JordyP2_Apl.Entidades{

    public class Proyectos{
        [Key]

        public int ProyectoId { get; set; }
        public DateTime Fecha { get; set; }= DateTime.Now;
        public string Descripcion { get; set; }
        public double TiempoTotal { get; set; }

        [ForeignKey("ProyectoId")]
        public virtual List<ProyectoDetalle> Detalle {get; set;}= new List<ProyectoDetalle>();
    }
}