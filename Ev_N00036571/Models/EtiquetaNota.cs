using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_N00036571.Models
{
    public class EtiquetaNota
    {
        public int Id { get; set; }
        public int Id_etiqueta { get; set; }
        public int IdNota { get; set; } 
        public Etiqueta Etiqueta { get; set; }
        public Nota nota { get; set; }
    }
}
