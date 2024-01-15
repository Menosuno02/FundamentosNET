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
        public Form22Files()
        {
            InitializeComponent();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            // Objeto para seleccionar el fichero
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                FileInfo file = new FileInfo(path);
                // Con TextReader vamos a abrir y leer el fichero
                // using para asegurarnos de que se ha creado reader
                using (TextReader reader = file.OpenText())
                {
                    // read asíncrono, usamos await
                    string contenido = await reader.ReadToEndAsync();
                    reader.Close();
                    this.txtContenido.Text = contenido;
                    this.DibujarNombresListbox(contenido);
                }
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
            SaveFileDialog svf = new SaveFileDialog();
            if (svf.ShowDialog() == DialogResult.OK)
            {
                string path = svf.FileName;
                FileInfo file = new FileInfo(path);
                // Usamos TextWriter
                using (TextWriter writer = file.CreateText())
                {
                    string contenido = GetNombresListbox();
                    await writer.WriteAsync(contenido);
                    await writer.FlushAsync();
                    writer.Close();
                    MessageBox.Show("Datos almacenados");
                }
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