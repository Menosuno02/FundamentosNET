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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtPosicionX.Text);
            int y = int.Parse(txtPosicionY.Text);
            btnPosicion.Location = new Point(x, y);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtRojo.Text);
            int verde = int.Parse(txtVerde.Text);
            int azul = int.Parse(txtAzul.Text);
            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
