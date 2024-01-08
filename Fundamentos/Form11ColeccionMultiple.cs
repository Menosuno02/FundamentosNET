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
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elemento = this.txtNuevo.Text;
            this.lstElementos.Items.Add(elemento);
            this.txtNuevo.Focus();
            this.txtNuevo.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string elementos = "";
            foreach (int indice in this.lstElementos.SelectedIndices)
            {
                indices += indice + ",";
            }
            this.lblIndiceSeleccionado.Text = indices.Trim(',');
            foreach (string elemento in this.lstElementos.SelectedItems)
            {
                elementos += elemento + ",";
            }
            this.lblSeleccionado.Text = elementos.Trim(',');
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.lstElementos.SelectedIndices.Count; i++)
            {
                this.lstElementos.Items.RemoveAt(this.lstElementos.SelectedIndices[i]);
            }
        }
    }
}