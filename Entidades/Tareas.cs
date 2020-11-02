using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JordyP2_Apl.Entidades{

    public class Tareas{
        [Key]

        public int TareaId { get; set; }
        public string TipoTarea { get; set; }
    }
}