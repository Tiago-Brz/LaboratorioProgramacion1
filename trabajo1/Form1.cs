using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo1
{
    public partial class Form1 : Form
    {
        private string[] valores = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        private string[] palos = { "Espada", "Basto", "Copas", "Oro" };
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Mezclar_btn_Click(object sender, EventArgs e)
        {
            string carta1 = MezclarCartas();
            string carta2 = MezclarCartas();
            string carta3 = MezclarCartas();

            Cartas_lbl.Text = carta1+"\n"+carta2+"\n"+carta3;
        }
        private string MezclarCartas()
        {
            string valor = valores[random.Next(valores.Length)];
            string palo = palos[random.Next(palos.Length)];

            return (valor+"-"+palo);
        }

        private void Salir_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
