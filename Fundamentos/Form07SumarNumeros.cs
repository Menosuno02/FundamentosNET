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
    public partial class Form07SumarNumeros : Form
    {
        public Form07SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string secuencia = this.txtSecuencia.Text;
            int suma = 0;
            for (int i = 0; i < secuencia.Length; i++)
            {
                // suma += Convert.ToInt32(secuencia[i].ToString());
                suma += int.Parse(secuencia[i].ToString());
            }
            this.txtResult.Text = "La suma de " + secuencia + " es " + suma;
        }
    }
}