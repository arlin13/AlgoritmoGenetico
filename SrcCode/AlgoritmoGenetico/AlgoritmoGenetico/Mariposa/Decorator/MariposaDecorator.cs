using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    public class MariposaDecorator : Mariposa
    {
        protected Mariposa _mariposa;

        public MariposaDecorator(Mariposa mariposa)
        {
            _mariposa = mariposa;
        }

        public override string ObtieneDescripcion()
        {
            return _mariposa.Descripcion;
        }
    }
}
