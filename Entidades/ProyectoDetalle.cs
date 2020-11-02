using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JordyP2_Apl.Entidades{

    public class ProyectoDetalle{
        [Key]

        public int Id { get; set; }
        public int ProyectoId { get; set;}
        public int TareaId { get; set; }
        public string Requerimiento { get; set; }
        public double Tiempo { get; set;}

        [ForeignKey("TareaId")]
        public Tareas tipo { get; set; }= new Tareas();
        
    }
}