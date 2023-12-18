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
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnDiaNacimiento_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anyo = int.Parse(txtAnyo.Text);
            DateTime diaNacimiento = new DateTime(anyo, mes, dia);
            txtDiaSemana.Text = diaNacimiento.DayOfWeek.ToString();
        }
    }
}