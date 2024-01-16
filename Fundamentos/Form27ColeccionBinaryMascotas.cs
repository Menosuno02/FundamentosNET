using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fundamentos
{
    public partial class Form27ColeccionBinaryMascotas : Form
    {
        private BinaryFormatter formatter;
        private ColeccionMascotas mascotasList;

        public Form27ColeccionBinaryMascotas()
        {
            InitializeComponent();
            this.formatter = new BinaryFormatter();
            this.mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("listamascotas.dat", FileMode.Open))
            {
                this.mascotasList = (ColeccionMascotas)this.formatter.Deserialize(fs);
                fs.Close();
                DibujarMascotas();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("listamascotas.dat", FileMode.Create))
            {
                this.formatter.Serialize(fs, mascotasList);
                await fs.FlushAsync();
                fs.Close();
                this.mascotasList.Clear();
                this.lstMascotas.Items.Clear();
            }
        }
    }
}