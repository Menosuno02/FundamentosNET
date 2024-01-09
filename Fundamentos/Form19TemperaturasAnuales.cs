using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form19TemperaturasAnuales : Form
    {
        private string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        private List<int> temperaturas;
        private Random random;

        public Form19TemperaturasAnuales()
        {
            InitializeComponent();
            this.random = new Random();
            this.temperaturas = new List<int>();
        }

        private void btnGenerarMeses_Click(object sender, EventArgs e)
        {
            foreach (string mes in this.meses)
            {
                int temp = random.Next(-15, 40);
                temperaturas.Add(temp);
                lstTemperaturas.Items.Add(mes + ": " + temp.ToString());
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int max = -16;
            int min = 41;
            int media = 0;
            foreach (int temp in temperaturas)
            {
                if (temp > max)
                {
                    max = temp;
                }
                if (temp < min)
                {
                    min = temp;
                }
                media += temp;
            }
            media /= temperaturas.Count;
            this.txtTemperaturaMin.Text = min.ToString();
            this.txtTemperaturaMax.Text = max.ToString();
            this.txtMedia.Text = media.ToString();
        }
    }
}