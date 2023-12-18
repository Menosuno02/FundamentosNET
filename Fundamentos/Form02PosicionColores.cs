namespace Fundamentos
{
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtPosicionX.Text);
            int y = int.Parse(txtPosicionY.Text);
            btnPosicion.Location = new Point(x, y);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(txtRojo.Text);
            int verde = int.Parse(txtVerde.Text);
            int azul = int.Parse(txtAzul.Text);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor del rojo es incorrecto");
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor del verde es incorrecto");
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor del azul es incorrecto");
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}