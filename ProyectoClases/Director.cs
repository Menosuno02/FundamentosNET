using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director : Empleado
    {
        public Director()
        {
            Debug.WriteLine("Constructor director");
            this.SalarioMinimo += 200;
        }

        public new int GetDiasVacaciones()
        {
            int vacaciones = base.GetDiasVacaciones();
            Debug.WriteLine("GetDiasVacaciones Director");
            return vacaciones + 8;
        }
    }
}