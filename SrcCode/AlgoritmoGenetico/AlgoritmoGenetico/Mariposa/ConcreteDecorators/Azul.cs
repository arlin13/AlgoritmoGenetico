using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    class Azul : MariposaDecorator
    {
        public Azul(Mariposa mariposa)
            : base(mariposa)
        {
            Descripcion = "Azul. ";
        }

        public override string ObtieneDescripcion()
        {
            return _mariposa.ObtieneDescripcion() + Descripcion;            
        }
    }
}
