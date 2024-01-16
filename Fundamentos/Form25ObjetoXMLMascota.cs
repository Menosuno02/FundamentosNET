using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Fundamentos
{
    public partial class Form25ObjetoXMLMascota : Form
    {
        private XmlSerializer serializer;

        public Form25ObjetoXMLMascota()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Lectura con StreamReader
            Mascota mascota = new Mascota();
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                // Recuperamos el texto XML y lo pasamos a objeto mediante Deserialize()
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
            }
            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Years.ToString();
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = Convert.ToInt32(this.txtEdad.Text);
            // Escritura con StreamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                // Serializamos el objeto a formato XML con Serialize()
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();
        }
    }
}