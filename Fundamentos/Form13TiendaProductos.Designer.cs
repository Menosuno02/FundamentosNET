namespace Fundamentos
{
    partial class Form13TiendaProductos
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
            lblProducto = new Label();
            txtProducto = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnBorrarTodos = new Button();
            lblTienda = new Label();
            lstTienda = new ListBox();
            lblProductos = new Label();
            lstProductos = new ListBox();
            btnSubir = new Button();
            btnBajar = new Button();
            btnSeleccionar = new Button();
            btnTodos = new Button();
            SuspendLayout();
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(12, 9);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(56, 15);
            lblProducto.TabIndex = 0;
            lblProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 27);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(119, 23);
            txtProducto.TabIndex = 1;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(12, 67);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(119, 23);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 96);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 125);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(119, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.Location = new Point(12, 154);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(119, 23);
            btnBorrarTodos.TabIndex = 5;
            btnBorrarTodos.Text = "Borrar todos";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            btnBorrarTodos.Click += btnBorrarTodos_Click;
            // 
            // lblTienda
            // 
            lblTienda.AutoSize = true;
            lblTienda.Location = new Point(156, 9);
            lblTienda.Name = "lblTienda";
            lblTienda.Size = new Size(42, 15);
            lblTienda.TabIndex = 6;
            lblTienda.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.ItemHeight = 15;
            lstTienda.Location = new Point(156, 27);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(143, 184);
            lstTienda.TabIndex = 7;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(386, 9);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(61, 15);
            lblProductos.TabIndex = 8;
            lblProductos.Text = "Productos";
            // 
            // lstProductos
            // 
            lstProductos.FormattingEnabled = true;
            lstProductos.ItemHeight = 15;
            lstProductos.Location = new Point(386, 27);
            lstProductos.Name = "lstProductos";
            lstProductos.Size = new Size(143, 184);
            lstProductos.TabIndex = 9;
            lstProductos.SelectedIndexChanged += lstProductos_SelectedIndexChanged;
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(535, 79);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(75, 23);
            btnSubir.TabIndex = 10;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(535, 108);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(75, 23);
            btnBajar.TabIndex = 11;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(305, 79);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(75, 23);
            btnSeleccionar.TabIndex = 12;
            btnSeleccionar.Text = "Selección";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(305, 108);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(75, 23);
            btnTodos.TabIndex = 13;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 232);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstProductos);
            Controls.Add(lblProductos);
            Controls.Add(lstTienda);
            Controls.Add(lblTienda);
            Controls.Add(btnBorrarTodos);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProducto;
        private TextBox txtProducto;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnBorrarTodos;
        private Label lblTienda;
        private ListBox lstTienda;
        private Label lblProductos;
        private ListBox lstProductos;
        private Button btnSubir;
        private Button btnBajar;
        private Button btnSeleccionar;
        private Button btnTodos;
    }
}