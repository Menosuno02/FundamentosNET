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
    public partial class Form05ClaseChar : Form
    {
        public Form05ClaseChar()
        {
            InitializeComponent();
        }

        private void btnAscii_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 255; i++)
            {
                char caracter = (char)i;
                if (char.IsLetter(caracter))
                {
                    this.txtLetras.Text += caracter;
                }
                else if (char.IsDigit(caracter))
                {
                    this.txtDígitos.Text += caracter;
                }
                else if (char.IsSymbol(caracter))
                {
                    this.txtSimbolos.Text += caracter;
                }
                else if (char.IsPunctuation(caracter))
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}