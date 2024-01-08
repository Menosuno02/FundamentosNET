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
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        // RECIBIMOS EL WRAPPER POR VALOR
        private void GetDobleValor(int num)
        {
            num = num * 2;
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        private void CambiarColor(Button boton)
        {
            boton.BackColor = Color.BlueViolet;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(this.txtNumero.Text);
            int doble = this.GetDobleOk(numero);
            // this.GetDobleReferencia(ref numero);
            this.lblResultado.Text = doble.ToString();
        }

        private int GetDobleOk(int num)
        {
            return num * 2;
        }

        private void GetDobleReferencia(ref int num)
        {
            num = num * 2;
        }

        private void Form14Metodos_Load(object sender, EventArgs e)
        {
        }

        private void Form14Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + ", Y: " + e.Y;
        }

        private void txtNúmeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Handled desactiva los eventos sucesivos del event (en este caso que se escriba la tecla en el TextBox)
            // KeyChar es la tecla puslada
            char teclaBorrar = (char)Keys.Back;
            this.lblResultado.Text = e.KeyChar.ToString();
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            this.lblResultado.Text = e.KeyChar.ToString();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}