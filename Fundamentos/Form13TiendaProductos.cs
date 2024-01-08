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
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
            this.btnSubir.Enabled = false;
            this.btnBajar.Enabled = false;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            if (!this.lstTienda.Items.Contains(producto))
            {
                this.lstTienda.Items.Add(producto);
            }
            else
            {
                this.lstTienda.SelectedIndex = -1;
                this.lstTienda.SelectedItem = producto;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstTienda.SelectedIndices.Count; i++)
            {
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
                i--;
            }
        }

        private void btnBorrarTodos_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstTienda.SelectedIndices.Count; i++)
            {
                this.lstTienda.Items[this.lstTienda.SelectedIndices[i]] = this.txtProducto.Text;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstTienda.SelectedIndices.Count; i++)
            {
                this.lstProductos.Items.Add(this.lstTienda.Items[this.lstTienda.SelectedIndices[i]]);
                this.lstTienda.Items.RemoveAt(this.lstTienda.SelectedIndices[i]);
                i--;
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstTienda.Items.Count; i++)
            {
                this.lstProductos.Items.Add(this.lstTienda.Items[i]);
            }
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            string producto = Convert.ToString(this.lstProductos.SelectedItem);
            string producto2 = Convert.ToString(this.lstProductos.Items[index - 1]);
            this.lstProductos.Items[index - 1] = producto;
            this.lstProductos.Items[index] = producto2;
            this.lstProductos.SelectedIndex = index - 1;
            // this.lstProductos.Items.Insert(indice - 1, producto);
            // this.lstProductos.SelectedIdnex = indice - 1;
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            string producto = Convert.ToString(this.lstProductos.SelectedItem);
            string producto2 = Convert.ToString(this.lstProductos.Items[index + 1]);
            this.lstProductos.Items[index + 1] = producto;
            this.lstProductos.Items[index] = producto2;
            this.lstProductos.SelectedIndex = index + 1;
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstProductos.SelectedIndex;
            if (index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else if (index == this.lstProductos.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
                this.btnBajar.Enabled = true;
            }
        }
    }
}