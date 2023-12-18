namespace Fundamentos
{
    public partial class FormPrimer : Form
    {
        public FormPrimer()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Location = new Point(100, 140);
            this.txtNombre.Text = "Pulsado";
            this.txtNombre.Width = 150;
            this.BackColor = Color.Red;
            this.txtNombre.TextAlign = HorizontalAlignment.Center;

            short pequeño = 888;
            int numero = pequeño;
            string texto = "12345";
            int textoNum = int.Parse(texto);
            string boton = this.btnPulsar.ToString();
            int mayor = 88;
            short otro = (short)mayor;
        }
    }
}