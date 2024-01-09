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
    public partial class Form16ListDelegados : Form
    {
        private List<Button> botones;
        private int contador;

        public Form16ListDelegados()
        {
            InitializeComponent();
            // Queremos incluir todos los botones en una colección, recorrerla y delegar el evento click
            // Dentro de forms tenemos una propiedad llamada control que contiene todos los controles del formulario
            // Dicha propiedad funciona por containers. Si tenemos un GroupBox, debemos recorrer Control del contenedor GroupBox
            // Podríamos realizar esto con Controls, pero por norma siempre crearemos nuestras colecciones
            this.botones = new List<Button>();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
            }
            foreach (Button boton in botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        private void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = "Contador: " + this.contador;
            // Cuando pulsemos un botón, quiero cambiar su color
            Button boton = ((Button)sender);
            boton.BackColor = Color.Red;
            /*
            int numero = this.botones.Count;
            MessageBox.Show("Has hecho click " + numero);
            */
        }
    }
}