namespace Fundamentos
{
    partial class Form23Mascotas
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtRaza = new TextBox();
            btnCreate = new Button();
            btnLeer = new Button();
            btnGuardar = new Button();
            label3 = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(115, 23);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(12, 80);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(115, 23);
            txtRaza.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 118);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 23);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Crear mascota";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(12, 147);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(115, 23);
            btnLeer.TabIndex = 5;
            btnLeer.Text = "Leer mascotas";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 176);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 23);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar mascotas";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 9);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 15;
            lstMascotas.Location = new Point(144, 27);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(120, 169);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form23Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 210);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(btnCreate);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23Mascotas";
            Text = "Form23Mascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtRaza;
        private Button btnCreate;
        private Button btnLeer;
        private Button btnGuardar;
        private Label label3;
        private ListBox lstMascotas;
    }
}