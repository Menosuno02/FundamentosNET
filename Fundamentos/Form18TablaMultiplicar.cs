using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form18TablaMultiplicar : Form
    {
        private List<TextBox> textBoxes;

        public Form18TablaMultiplicar()
        {
            InitializeComponent();
            this.textBoxes = new List<TextBox>();
            foreach (TextBox txtbox in this.pnlTabla.Controls)
            {
                this.textBoxes.Add(txtbox);
            }
            this.textBoxes.Reverse();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(this.txtSuma.Text);
            for (int i = 0; i < this.textBoxes.Count; i++)
            {
                this.textBoxes[i].Text = (num * (i + 1)).ToString();
            }
        }
    }
}