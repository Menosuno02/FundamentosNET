namespace Fundamentos
{
    partial class Form11ColeccionMultiple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtNuevo = new TextBox();
            lblNuevo = new Label();
            lblIndiceSeleccionado = new Label();
            lblSeleccionado = new Label();
            lblElementos = new Label();
            lstElementos = new ListBox();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(215, 146);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(139, 23);
            btnBorrarTodo.TabIndex = 17;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(215, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 23);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(215, 59);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 23);
            btnInsertar.TabIndex = 15;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(215, 30);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(139, 23);
            txtNuevo.TabIndex = 14;
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(215, 12);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(95, 15);
            lblNuevo.TabIndex = 13;
            lblNuevo.Text = "Nuevo elemento";
            // 
            // lblIndiceSeleccionado
            // 
            lblIndiceSeleccionado.AutoSize = true;
            lblIndiceSeleccionado.Location = new Point(12, 265);
            lblIndiceSeleccionado.Name = "lblIndiceSeleccionado";
            lblIndiceSeleccionado.Size = new Size(122, 15);
            lblIndiceSeleccionado.TabIndex = 12;
            lblIndiceSeleccionado.Text = "lblIndiceSeleccionado";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(12, 241);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(90, 15);
            lblSeleccionado.TabIndex = 11;
            lblSeleccionado.Text = "lblSeleccionado";
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(12, 12);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(62, 15);
            lblElementos.TabIndex = 10;
            lblElementos.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 15;
            lstElementos.Location = new Point(12, 30);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(195, 199);
            lstElementos.TabIndex = 9;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(215, 117);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(139, 23);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 296);
            Controls.Add(btnSeleccionados);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(lblNuevo);
            Controls.Add(lblIndiceSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(lblElementos);
            Controls.Add(lstElementos);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtNuevo;
        private Label lblNuevo;
        private Label lblIndiceSeleccionado;
        private Label lblSeleccionado;
        private Label lblElementos;
        private ListBox lstElementos;
        private Button btnSeleccionados;
    }
}