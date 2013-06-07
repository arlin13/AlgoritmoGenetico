using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoGenetico
{
    public partial class Form1 : Form
    {
        private const int height = 50;
        private const int width = 50;
        private int _individuos = 100;

        private PictureBox[] _pictureBoxs;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            int y = 5;
            _pictureBoxs = new PictureBox[_individuos];
            for (int i = 0; i < _individuos / 10; i++)
            {
                DibujaRenglon(i, y);
                y += 55;
            }
        }

        private void DibujaRenglon(int valor, int y)
        {
            int x = 5;
            for (int i = 0; i < 10; i++)
            {
                _pictureBoxs[i + (valor * 10)] = new PictureBox()
                    {
                        Location = new Point(x, y),
                        Size = new Size(width, height),
                        BackColor = Color.Violet
                    };
                panelPictureBox.Controls.Add(_pictureBoxs[i + (valor * 10)]);
                x += 55;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonPoblacion50_CheckedChanged(object sender, EventArgs e)
        {
            _individuos = 50;
            panelPictureBox.Controls.Clear();
            InitializeGrid();
        }

        private void radioButtonPoblacion100_CheckedChanged(object sender, EventArgs e)
        {
            _individuos = 100;
            panelPictureBox.Controls.Clear();
            InitializeGrid();
        }
    }
}
