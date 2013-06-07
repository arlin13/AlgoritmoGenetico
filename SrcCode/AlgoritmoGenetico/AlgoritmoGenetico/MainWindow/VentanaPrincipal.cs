using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGenetico.MainWindow
{
    public partial class VentanaPrincipal : Form
    {
        private const int height = 50;
        private const int width = 50;
        private int _individuos = 100;
        private int _generacion = 0;
        private bool _isGoalState = false;

        private List<Mariposa> _poblacion;
        private List<Mariposa> _poblacionHijos;
        private PictureBox[] _pictureBoxs;

        public VentanaPrincipal()
        {
            InitializeComponent();
            InitializeGrid();
            InitializeArray();
            SetImages();
        }

        private void InitializeArray()
        {
            var random = new Random();
            _poblacion = new List<Mariposa>();
            _poblacionHijos = new List<Mariposa>();
            for (int i = 0; i < _individuos; i++)
            {
                int antena = random.Next(0, 2);
                int espiritrompa = random.Next(0, 2);
                int color = random.Next(0, 3);
                int forma = random.Next(0, 2);
                int tam = random.Next(0, 2);
                //_poblacion[i] = new Mariposa(antena, espiritrompa, color, forma, tam);
                //_poblacion[i] = new Mariposa(0, 0, 2, 1, 0);
                //_poblacion.Add(new Mariposa(0, 0, 1, 1, 0));
                _poblacion.Add(new Mariposa(antena, espiritrompa, color, forma, tam));
            }
        }

        private void InitializeGrid()
        {
            int y = 5;
            _poblacion = new List<Mariposa>();
            _pictureBoxs = new PictureBox[_individuos];
            for (int i = 0; i < _individuos / 10; i++)
            {
                DibujaRenglon(i, y);
                y += 55;
            }
        }

        private void DibujaRenglon(int valor, int y)
        {
            var random = new Random();

            int x = 5;
            for (int i = 0; i < 10; i++)
            {
                _pictureBoxs[i + (valor * 10)] = new PictureBox()
                    {
                        Location = new Point(x, y),
                        Size = new Size(width, height)
                        //,BackColor = Color.CadetBlue
                    };

                panelPictureBox.Controls.Add(_pictureBoxs[i + (valor * 10)]);
                x += 55;
            }
        }

        private void SetImages()
        {
            for (int i = 0; i < _poblacion.Count; i++)
            {
                string nombre = string.Empty;

                var arregloGenotipo = _poblacion[i].Genotipo;
                if (arregloGenotipo[0] == 0) // Antena
                    nombre += '0';
                else if (arregloGenotipo[0] == 1)
                    nombre += '1';
                if (arregloGenotipo[1] == 0) // Espiritrompa
                    nombre += '0';
                else if (arregloGenotipo[1] == 1)
                    nombre += '1';
                if (arregloGenotipo[2] == 0) // Color
                    nombre += '0';
                else if (arregloGenotipo[2] == 1)
                    nombre += '1';
                else if (arregloGenotipo[2] == 2)
                    nombre += '2';
                if (arregloGenotipo[3] == 0) // Forma ala
                    nombre += '0';
                else if (arregloGenotipo[3] == 1)
                    nombre += '1';
                if (arregloGenotipo[4] == 0) // Tam ala
                    nombre += '0';
                else if (arregloGenotipo[4] == 1)
                    nombre += '1';
                nombre += ".jpg";
                _pictureBoxs[i].Load(@"~/../../../Images/" + nombre);
            }
        }

        private void SetImages2()
        {
            int i = 0;
            foreach (var mariposa in _poblacion)
            {
                string nombre = string.Empty;

                var arregloGenotipo = mariposa.Genotipo;
                if (arregloGenotipo[0] == 0) // Antena
                    nombre += '0';
                else if (arregloGenotipo[0] == 1)
                    nombre += '1';
                if (arregloGenotipo[1] == 0) // Espiritrompa
                    nombre += '0';
                else if (arregloGenotipo[1] == 1)
                    nombre += '1';
                if (arregloGenotipo[2] == 0) // Color
                    nombre += '0';
                else if (arregloGenotipo[2] == 1)
                    nombre += '1';
                else if (arregloGenotipo[2] == 2)
                    nombre += '2';
                if (arregloGenotipo[3] == 0) // Forma ala
                    nombre += '0';
                else if (arregloGenotipo[3] == 1)
                    nombre += '1';
                if (arregloGenotipo[4] == 0) // Tam ala
                    nombre += '0';
                else if (arregloGenotipo[4] == 1)
                    nombre += '1';
                nombre += ".jpg";
                _pictureBoxs[i].Load(@"~/../../../Images/" + nombre);
                i++;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CalcularFuncionObjetivo();
        }

        private void CalcularFuncionObjetivo()
        {
            int promedioAptPoblacion1 = _poblacion.Sum(t => t.GetAptitud()) / 100;
            int promedioAptPoblacion2 = (int)_poblacion.Average(t => t.GetAptitud());

            if (promedioAptPoblacion1 < 80)
            {
                ComenzarAlgoritmoGenetico();
            }
            else
            {
                _isGoalState = true;
                MessageBox.Show("Se ha alcanzado la función objetivo");
            }
        }

        private void ComenzarAlgoritmoGenetico()
        {
            while (!_isGoalState)
            {
                SeleccionPadres();
            }
        }

        private void SeleccionPadres()
        {
            for (int i = 0; i < _poblacion.Count; i += 2)
            {
                Mariposa p1 = _poblacion.ElementAt(i);
                Mariposa p2 = _poblacion.ElementAt(i + 1);

                Mariposa h1 = CrossOver(p1, p2);
                Mariposa h2 = CrossOver(p2, p1);

                _poblacionHijos.Add(h1);
                _poblacionHijos.Add(h2);
            }
        }

        private Mariposa CrossOver(Mariposa p1, Mariposa p2)
        {
            int antena = p1.Genotipo[0];
            int espiritrompa = p1.Genotipo[1];
            int color = p2.Genotipo[2];
            int forma = p2.Genotipo[3];
            int tam = p2.Genotipo[4];

            return new Mariposa(antena, espiritrompa, color, forma, tam);
        }

    }
}

//public List<Mariposa> SeleccionPadresAleatoria(Mariposa poblacion)
//       {
//           Random random = new Random();
//           _padres = new List<Mariposa>();
//           int probabilidadPadre = random.Next();
//           Mariposa m;

//           for (int i = 0; i <= 2; i++)
//           {
//               int padreSeleccionado = random.Next(0, 100);
//               if (probabilidadPadre < 0.8)
//               {
//                   m = new Mariposa();
//                   _padres.Add(m); //poblacion._genotipo[padreSeleccionado]);
//                  //padres[i] = poblacion._genotipo[padreSeleccionado];
//               }
//               else
//                   SeleccionPadresAleatoria(poblacion);
//           }
//           return _padres;
//       }