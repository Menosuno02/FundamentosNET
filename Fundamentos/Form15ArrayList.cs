using System;
using System.Collections;
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
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            this.button1.Click += Button1_Click;


            InitializeComponent();
            // Colección genérica
            List<Button> listaBotones = new List<Button>();
            listaBotones.Add(this.button1);
            listaBotones.Add(this.button2);
            listaBotones.Add(this.button3);
            listaBotones[1].BackColor = Color.Yellow;
            // listaBotones.Add(this.textBox1); da error

            // Colección no tipada
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1);
            // Tenemos que realizar casting para aplicar propiedades
            ((Button)coleccion[0]).Text = "Soy un botón";
            /*
            foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.Aqua;
            }
            */
            foreach (Control control in coleccion)
            {
                control.BackColor = Color.LawnGreen;
                if (control is TextBox)
                {
                    ((TextBox)control).Paste();
                }
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}