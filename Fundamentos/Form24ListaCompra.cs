using ProyectoClases.Helpers;
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

namespace Fundamentos
{
    public partial class Form24ListaCompra : Form
    {
        private HelperProductos helper;

        public Form24ListaCompra()
        {
            InitializeComponent();
            helper = new HelperProductos();
        }

        private void DibujarProductosListbox()
        {
            this.lstProductos.Items.Clear();
            foreach (Producto producto in helper.Productos)
            {
                this.lstProductos.Items.Add(producto.Nombre);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = this.txtNombre.Text;
            producto.Cantidad = Convert.ToInt32(this.txtCantidad.Text);
            this.helper.Productos.Add(producto);
            this.DibujarProductosListbox();
        }

        private async void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                await this.helper.ReadProductosAsync(path);
                this.DibujarProductosListbox();
            }
        }

        private async void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string path = sfd.FileName;
                await this.helper.WriteProductosAsync(path);
                this.DibujarProductosListbox();
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            Producto prod = this.helper.Productos[index];
            this.txtNombre.Text = prod.Nombre;
            this.txtCantidad.Text = prod.Cantidad.ToString();
        }
    }
}