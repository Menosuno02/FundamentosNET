namespace Fundamentos
{
    partial class Form27ColeccionBinaryMascotas
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
            btnCreate = new Button();
            btnGuardar = new Button();
            btnLeer = new Button();
            lstMascotas = new ListBox();
            label4 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(11, 211);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(100, 23);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Nuevo dato";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(277, 60);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 23);
            btnGuardar.TabIndex = 20;
            btnGuardar.Text = "Guardar datos";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(277, 30);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(94, 23);
            btnLeer.TabIndex = 19;
            btnLeer.Text = "Leer datos";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 15;
            lstMascotas.Location = new Point(133, 31);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(120, 169);
            lstMascotas.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(133, 13);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 17;
            label4.Text = "Mascotas";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(11, 169);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 151);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 15;
            label3.Text = "Años";
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(11, 99);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 81);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 13;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(11, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre";
            // 
            // Form27ColeccionBinaryMascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 248);
            Controls.Add(btnCreate);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form27ColeccionBinaryMascotas";
            Text = "Form27ColeccionBinaryMascotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnGuardar;
        private Button btnLeer;
        private ListBox lstMascotas;
        private Label label4;
        private TextBox txtEdad;
        private Label label3;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
    }
}