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
    public partial class Form09CalcularLetraDNI : Form
    {
        public Form09CalcularLetraDNI()
        {
            InitializeComponent();
        }

        private void btnCalcularLetra_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            int dniNum = int.Parse(dni.Substring(0, dni.Length - 1));
            string letras = "TRWAGMYFPDXBNJZSQVHLCKET";
            if (letras[dniNum - (dniNum / 23) * 23] == dni[dni.Length - 1])
            {
                this.txtLetra.Text = "DNI válido ";
                this.txtLetra.Text += letras[dniNum - (dniNum / 23) * 23].ToString();
            }
            else this.txtLetra.Text = "DNI inválido";
        }
    }
}