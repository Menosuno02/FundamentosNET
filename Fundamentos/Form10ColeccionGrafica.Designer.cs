namespace Fundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            lblElementos = new Label();
            lblSeleccionado = new Label();
            lblIndiceSeleccionado = new Label();
            lblNuevo = new Label();
            txtNuevo = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            SuspendLayout();
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 15;
            lstElementos.Location = new Point(12, 27);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(195, 199);
            lstElementos.TabIndex = 0;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // lblElementos
            // 
            lblElementos.AutoSize = true;
            lblElementos.Location = new Point(12, 9);
            lblElementos.Name = "lblElementos";
            lblElementos.Size = new Size(62, 15);
            lblElementos.TabIndex = 1;
            lblElementos.Text = "Elementos";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Location = new Point(12, 238);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(90, 15);
            lblSeleccionado.TabIndex = 2;
            lblSeleccionado.Text = "lblSeleccionado";
            // 
            // lblIndiceSeleccionado
            // 
            lblIndiceSeleccionado.AutoSize = true;
            lblIndiceSeleccionado.Location = new Point(12, 262);
            lblIndiceSeleccionado.Name = "lblIndiceSeleccionado";
            lblIndiceSeleccionado.Size = new Size(122, 15);
            lblIndiceSeleccionado.TabIndex = 3;
            lblIndiceSeleccionado.Text = "lblIndiceSeleccionado";
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(215, 9);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(95, 15);
            lblNuevo.TabIndex = 4;
            lblNuevo.Text = "Nuevo elemento";
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(215, 27);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(139, 23);
            txtNuevo.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(215, 56);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 23);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(215, 85);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(215, 114);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(139, 23);
            btnBorrarTodo.TabIndex = 8;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 291);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevo);
            Controls.Add(lblNuevo);
            Controls.Add(lblIndiceSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(lblElementos);
            Controls.Add(lstElementos);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstElementos;
        private Label lblElementos;
        private Label lblSeleccionado;
        private Label lblIndiceSeleccionado;
        private Label lblNuevo;
        private TextBox txtNuevo;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
    }
}