using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo2
{
    public partial class Form1 : Form
    {
        private int[][] resultados = new int[3][];
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTirarDados_Click_1(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 3; i++)
            {
                resultados[i] = TirarDados();
            }

       
            MostrarResultados();
        }

        private int[] TirarDados()
        {
            int[] dados = new int[5];

            for (int i = 0; i < 5; i++)
            {
                dados[i] = random.Next(1, 7); 
            }

            return dados;
        }

        private void MostrarResultados()
        {
            lblResultados.Text = "Resultados de las 3 tiradas:\n";

            for (int i = 0; i < 3; i++)
            {
                lblResultados.Text += $"Tirada {i + 1}: {string.Join(", ", resultados[i])}\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}