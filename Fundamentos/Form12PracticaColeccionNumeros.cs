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
    public partial class Form12PracticaColeccionNumeros : Form
    {
        public Form12PracticaColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.lstNumeros.Items.Add(random.Next(1, 50));
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach (int numero in this.lstNumeros.Items)
            {
                suma += numero;
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}