using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        public List<Mascota> Mascotas { get; set; }

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();
        }

        public async Task WriteMascotasAsync(string path)
        {
            string data = this.ConvertMascotasString();
            await HelperFiles.WriteFileAsync(path, data);
        }

        public async Task ReadMascotasAsync(string path)
        {
            string data = await HelperFiles.ReadFileAsync(path);
            this.ConvertMascotasList(data);
        }

        private string ConvertMascotasString()
        {
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                data += mascota.Nombre + "," + mascota.Raza + "#";
            }
            return data.TrimEnd('#');
        }

        private void ConvertMascotasList(string text)
        {
            this.Mascotas.Clear();
            foreach (string mascotaString in text.Split("#"))
            {
                string[] propiedades = mascotaString.Split(",");
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }
        }
    }
}