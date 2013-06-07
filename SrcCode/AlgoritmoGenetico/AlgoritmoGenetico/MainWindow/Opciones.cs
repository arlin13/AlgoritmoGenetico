using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoGenetico.MainWindow
{
    public partial class VentanaPrincipal
    {
        #region Poblacion
        private void radioButtonPoblacion50_CheckedChanged(object sender, EventArgs e)
        {
            _individuos = 50;
            panelPictureBox.Controls.Clear();
            InitializeGrid();
            InitializeArray();
            SetImages();
        }

        private void radioButtonPoblacion100_CheckedChanged(object sender, EventArgs e)
        {
            _individuos = 100;
            panelPictureBox.Controls.Clear();
            InitializeGrid();
            InitializeArray();
            SetImages();
        }
        #endregion Poblacion
    }
}
