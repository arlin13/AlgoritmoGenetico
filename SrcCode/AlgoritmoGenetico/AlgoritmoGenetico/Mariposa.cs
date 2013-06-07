using AlgoritmoGenetico.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico
{
    public class Mariposa
    {
        public int[] Genotipo = new int[5];

        public Mariposa(int antena, int espiritrompa, int color, int forma, int tam)
        {
            Genotipo = new int[] { antena, espiritrompa, color, forma, tam };
        }

        public int GetAptitud()
        {
            return (GetAptAntena() + GetAptEspiritrompa() + GetAptColor() + GetAptForma() + GetAptTam());
        }

        private int GetAptAntena()
        {
            return Genotipo[0] == 0 ? 5 : 10;
        }

        private int GetAptEspiritrompa()
        {
            return Genotipo[1] == 0 ? 10 : 25;
        }

        private int GetAptColor()
        {
            return Genotipo[2] == 0 || Genotipo[2] == 1 ? 35 : 15;
        }

        private int GetAptForma()
        {
            return Genotipo[3] == 0 ? 15 : 10;
        }

        private int GetAptTam()
        {
            return Genotipo[4] == 0 ? 10 : 15;
        }
    }
}