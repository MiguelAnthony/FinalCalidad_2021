using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_N00036571.Models
{
    public class Nota
    {
       
        public int Id { set; get; }
        public string Titulo { set; get; }
        public DateTime Fecha { set; get; }
        public string Contenido { set; get; }
        public int IdUsuario { set; get; }

    }
}
