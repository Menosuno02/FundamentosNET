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
            /*
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anyo = int.Parse(txtAnyo.Text);
            DateTime diaNacimiento = new DateTime(anyo, mes, dia);
            txtDiaSemana.Text = diaNacimiento.DayOfWeek.ToString();
            */

            string[] diasSemana = { "Sábado", "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            int[] meses = { 13, 14, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int dia = int.Parse(txtDia.Text);
            int mes = meses[int.Parse(txtMes.Text) - 1];
            int anyo = int.Parse(txtAnyo.Text);
            if (mes == 13 || mes == 14) anyo--;

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;
            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);
            txtDiaSemana.Text = diasSemana[op7];
        }
    }
}