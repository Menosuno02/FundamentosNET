using ProyectoClases.Helpers;
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
    public partial class Form22Files : Form
    {
        //  private HelperFiles helper;

        public Form22Files()
        {
            InitializeComponent();
            // this.helper = new HelperFiles();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            // Objeto para seleccionar el fichero
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                string data = await HelperFiles.ReadFileAsync(path);
                this.DibujarNombresListbox(data);
            }
        }

        public void DibujarNombresListbox(string data)
        {
            string[] nombres = data.Split(",");
            this.lstNombres.Items.Clear();
            foreach (string nombre in nombres)
            {
                this.lstNombres.Items.Add(nombre);
            }
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                string data = GetNombresListbox();
                await HelperFiles.WriteFileAsync(path, data);
                MessageBox.Show("Datos almacenados");
            }
        }

        public string GetNombresListbox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.TrimEnd(',');
            return data;
        }
    }
}