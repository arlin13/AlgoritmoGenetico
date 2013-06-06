using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class Cafe : MariposaDecorator
    {
        public Cafe(Mariposa mariposa)
            : base(mariposa)
        {
            Descripcion = "Café. ";
        }

        public override string ObtieneDescripcion()
        {
            return _mariposa.ObtieneDescripcion() + Descripcion;
        }
    }
}
