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
    public partial class Form17SumarBotones : Form
    {
        private List<Button> botones;
        private Random random;

        public Form17SumarBotones()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.random = new Random();
            this.txtSuma.Text = "0";
            foreach (Control control in panelBotones.Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.Click += BotonPulsado;
                }
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.txtSuma.Text = "0";
            foreach (Control control in panelBotones.Controls)
            {
                if (control is Button)
                {
                    Button boton = (Button)control;
                    boton.Text = random.Next(1, 100).ToString();
                    botones.Add(boton);
                }
            }
        }

        private void BotonPulsado(object sender, EventArgs e)
        {
            int suma = Convert.ToInt32(this.txtSuma.Text);
            suma += Convert.ToInt32(((Button)sender).Text);
            this.txtSuma.Text = suma.ToString();
        }
    }
}