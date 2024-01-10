﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Fundamentos
{
    public partial class Form20TestingClases : Form
    {
        public Form20TestingClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Nombre";
            persona.Apellidos = "Apellido";
            persona.Edad = 21;
            persona.Nacionalidad = Paises.Andorra;
            persona.Genero = TipoGenero.Masculino;
            persona.MetodoParametrosOpcionales(77);
            persona.MetodoParametrosOpcionales(8, 6);
            persona.MetodoParametrosOpcionales(55, 10, 432);
            persona.MetodoParametrosOpcionales(7, numero3: 87);
            // persona.Genero = (TipoGenero)99;
            this.lstDatosClases.Items.Add("Nombre: " + persona.GetNombreCompleto());
            this.lstDatosClases.Items.Add("Nombre al revés: " + persona.GetNombreCompleto(false));
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Género: " + persona.Genero);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
        }
    }
}