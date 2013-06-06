using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class Verde : MariposaDecorator
    {
        public Verde(Mariposa mariposa)
            : base(mariposa)
        {
            Descripcion = "Verde. ";
        }

        public override string ObtieneDescripcion()
        {
            return _mariposa.ObtieneDescripcion() + Descripcion;
        }
    }
}
