using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {
        public string Nombre { get; set; }
        public int TempMax { get; set; }
        public int TempMin { get; set; }
        public int Media { get; set; }

        public void GetMedia()
        {
            Media = (TempMax + TempMin) / 2;
        }

        public Mes()
        {
        }
    }
}