using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado : Persona
    {
        protected int SalarioMinimo { get; set; }

        public override string ToString()
        {
            return this.GetNombreCompleto();
        }

        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetDiasVacaciones Emple");
            return 22;
        }

        // Modificamos para leer constructor con parámetros de Persona
        public Empleado() : base("Nombre", "Apellidos")
        {
            Debug.WriteLine("Constructor empleado vacío");
            this.SalarioMinimo = 1200;
        }

        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }

        public Empleado(string nombre, string apellidos) : base("Nombre", "Apellidos")
        {
            Debug.WriteLine("Constructor empleado 2 params");
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}