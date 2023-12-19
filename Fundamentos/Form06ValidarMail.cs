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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            if (email.Contains('@')
                && !email.StartsWith("@")
                && !email.EndsWith("@")
                && email.IndexOf("@", email.IndexOf("@") + 1) == -1
                && email.Contains('.')
                && email.Substring(email.IndexOf("@")).Contains('.')
                && email.Substring(email.LastIndexOf(".")).Length >= 3
                && email.Substring(email.LastIndexOf(".")).Length <= 5)
            {
                this.txtValido.Text = "Email válido";
            }
            else
            {
                this.txtValido.Text = "Email inválido";
            }
        }
    }
}