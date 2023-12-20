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
            int dni = int.Parse(txtDNI.Text);
            string[] letras = { "T", "R", "W", "A", "G", "M",
                "Y", "F", "P", "D", "X", "B", "N", "J","Z",
                "S", "Q", "V", "H", "L", "C", "K", "E", "T" };
            this.txtLetra.Text = letras[dni - (dni / 23) * 23];
        }
    }
}