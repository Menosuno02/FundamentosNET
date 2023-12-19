namespace Fundamentos
{
    partial class Form05ClaseChar
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
            lblLetras = new Label();
            txtLetras = new TextBox();
            txtDígitos = new TextBox();
            lblDigitos = new Label();
            txtSimbolos = new TextBox();
            lblSimbolos = new Label();
            txtPuntuacion = new TextBox();
            lblPuntuacion = new Label();
            btnAscii = new Button();
            SuspendLayout();
            // 
            // lblLetras
            // 
            lblLetras.AutoSize = true;
            lblLetras.Location = new Point(12, 9);
            lblLetras.Name = "lblLetras";
            lblLetras.Size = new Size(38, 15);
            lblLetras.TabIndex = 0;
            lblLetras.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(12, 27);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(231, 80);
            txtLetras.TabIndex = 1;
            // 
            // txtDígitos
            // 
            txtDígitos.Location = new Point(263, 27);
            txtDígitos.Multiline = true;
            txtDígitos.Name = "txtDígitos";
            txtDígitos.Size = new Size(231, 80);
            txtDígitos.TabIndex = 3;
            // 
            // lblDigitos
            // 
            lblDigitos.AutoSize = true;
            lblDigitos.Location = new Point(263, 9);
            lblDigitos.Name = "lblDigitos";
            lblDigitos.Size = new Size(44, 15);
            lblDigitos.TabIndex = 2;
            lblDigitos.Text = "Dígitos";
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(12, 140);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(231, 80);
            txtSimbolos.TabIndex = 5;
            // 
            // lblSimbolos
            // 
            lblSimbolos.AutoSize = true;
            lblSimbolos.Location = new Point(12, 122);
            lblSimbolos.Name = "lblSimbolos";
            lblSimbolos.Size = new Size(56, 15);
            lblSimbolos.TabIndex = 4;
            lblSimbolos.Text = "Símbolos";
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(263, 140);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(231, 80);
            txtPuntuacion.TabIndex = 7;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(263, 122);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(68, 15);
            lblPuntuacion.TabIndex = 6;
            lblPuntuacion.Text = "Puntuación";
            // 
            // btnAscii
            // 
            btnAscii.Location = new Point(12, 237);
            btnAscii.Name = "btnAscii";
            btnAscii.Size = new Size(482, 23);
            btnAscii.TabIndex = 8;
            btnAscii.Text = "Recorrer ASCII";
            btnAscii.UseVisualStyleBackColor = true;
            btnAscii.Click += btnAscii_Click;
            // 
            // Form05ClaseChar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 280);
            Controls.Add(btnAscii);
            Controls.Add(txtPuntuacion);
            Controls.Add(lblPuntuacion);
            Controls.Add(txtSimbolos);
            Controls.Add(lblSimbolos);
            Controls.Add(txtDígitos);
            Controls.Add(lblDigitos);
            Controls.Add(txtLetras);
            Controls.Add(lblLetras);
            Name = "Form05ClaseChar";
            Text = "Form05ClaseChar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLetras;
        private TextBox txtLetras;
        private TextBox txtDígitos;
        private Label lblDigitos;
        private TextBox txtSimbolos;
        private Label lblSimbolos;
        private TextBox txtPuntuacion;
        private Label lblPuntuacion;
        private Button btnAscii;
    }
}