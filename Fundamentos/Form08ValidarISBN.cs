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
    public partial class Form08ValidarISBN : Form
    {
        public Form08ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtISBN.Text;
            if (isbn.Length != 10) this.txtValidez.Text = "ISBN inválido";
            else
            {
                bool todoNums = true;
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    if (!char.IsDigit(isbn[i]))
                    {
                        todoNums = false;
                        break;
                    }
                    suma += int.Parse(isbn[i].ToString()) * (i + 1);
                }
                if (todoNums && suma % 11 == 0)
                {
                    this.txtValidez.Text = "ISBN válido";
                }
                else this.txtValidez.Text = "ISBN inválido";
            }
        }
    }
}