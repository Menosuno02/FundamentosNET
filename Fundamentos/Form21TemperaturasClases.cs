using ProyectoClases;
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
    public partial class Form21TemperaturasClases : Form
    {
        private List<string> meses = new List<string>();

        public Form21TemperaturasClases()
        {
            InitializeComponent();
        }

        private void btnGenerarTemp_Click(object sender, EventArgs e)
        {
            meses.Clear();
            lstMeses.Items.Clear();
            Random random = new Random();
            DateTime fecha = DateTime.Parse("01/01/2024");
            for (int i = 1; i <= 12; i++)
            {
                int max = random.Next(-15, 40);
                int min = random.Next(-15, 40);
                string nombre = fecha.ToString("MMMM");
                if (min > max)
                {
                    int pivote = min;
                    min = max;
                    max = pivote;
                }
                Mes mesTemps = new Mes();
                mesTemps.Nombre = nombre;
                mesTemps.TempMax = max;
                mesTemps.TempMin = min;
                mesTemps.GetMedia();
                lstMeses.Items.Add(mesTemps);
                fecha = fecha.AddMonths(1);
            }
            lstMeses.DisplayMember = "Nombre";
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            Mes mes = (Mes)lstMeses.SelectedItem;
            txtMax.Text = mes.TempMax.ToString();
            txtMin.Text = mes.TempMin.ToString();
            txtMedia.Text = mes.Media.ToString();
        }
    }
}