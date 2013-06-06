using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class AlasPunteagudas : Mariposa
    {
        public AlasPunteagudas(Mariposa mariposa)
        {
            Descripcion = "Mariposa con alas punteagudas. ";
        }

        public override string ObtieneDescripcion()
        {
            return Descripcion;
        }
    }
}
