using AlgoritmoGenetico.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    public abstract class Mariposa
    {
        Ala ala;
        public string Descripcion { get; set; }
        public Espiritrompa espiritrompa { get; set; }
        public Antena antena { get; set; }

        public abstract string ObtieneDescripcion();
    }
}
