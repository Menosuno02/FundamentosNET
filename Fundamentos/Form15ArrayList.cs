﻿using System;
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
            InitializeComponent();
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
    }
}