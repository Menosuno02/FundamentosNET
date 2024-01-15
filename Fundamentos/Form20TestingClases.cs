using System;
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
            persona.Domicilio = new Direccion("Santa Engracia, 110", "Madrid");
            this.lstDatosClases.Items.Add("Calle: " + persona.Domicilio.Calle);
            persona[0] = "Descrìpción 1";
            persona[1] = "Descripción 2";
            this.lstDatosClases.Items.Add("Descripción[0]: " + persona[0]);
            this.lstDatosClases.Items.Add("Descripción[1]: " + persona[1]);

            // persona.Genero = (TipoGenero)99;
            this.lstDatosClases.Items.Add("Nombre: " + persona.GetNombreCompleto());
            this.lstDatosClases.Items.Add("Nombre al revés: " + persona.GetNombreCompleto(false));
            this.lstDatosClases.Items.Add("Edad: " + persona.Edad);
            this.lstDatosClases.Items.Add("Género: " + persona.Genero);
            this.lstDatosClases.Items.Add("Nacionalidad: " + persona.Nacionalidad);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            // Empleado emp = new Empleado("Empleado", "Apellidos");

            Empleado emp = new Empleado();
            emp.Nombre = "Empleado";
            emp.Apellidos = "Empleado";
            this.lstDatosClases.Items.Add(emp.ToString());
            this.lstDatosClases.Items.Add("Salario mínimo emple: " + emp.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones Emple: " + emp.GetDiasVacaciones());
            Director dir = new Director();
            dir.Nombre = "Dire";
            dir.Apellidos = "Dire";
            this.lstDatosClases.Items.Add(dir.ToString());
            this.lstDatosClases.Items.Add("Salario mínimo director: " + dir.GetSalarioMinimo());
            this.lstDatosClases.Items.Add("Vacaciones director: " + dir.GetDiasVacaciones());
        }
    }
}