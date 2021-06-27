using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TitulosEntity: EN // Herencia
    {
        public int? Id_Titulo { get; set; }

        public string Descripcion { get; set; }

        public  bool  Estado { get; set; }
    }
}
