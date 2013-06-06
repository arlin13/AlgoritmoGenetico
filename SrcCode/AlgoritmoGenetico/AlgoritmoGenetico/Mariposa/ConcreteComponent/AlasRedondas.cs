using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class AlasRedondas : Mariposa
    {
        public AlasRedondas(Mariposa mariposa)
        {
            Descripcion = "Mariposa con alas redondas. ";
        }

        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }
    }
}
