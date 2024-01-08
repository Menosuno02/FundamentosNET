namespace Fundamentos
{
    partial class Form12PracticaColeccionNumeros
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
            lblNumeros = new Label();
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnDatos = new Button();
            lblSuma = new Label();
            txtSuma = new TextBox();
            lblPares = new Label();
            txtPares = new TextBox();
            lblImpares = new Label();
            txtImpares = new TextBox();
            SuspendLayout();
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(12, 9);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(56, 15);
            lblNumeros.TabIndex = 0;
            lblNumeros.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(12, 27);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(120, 169);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(154, 9);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(93, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(154, 41);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(93, 23);
            btnDatos.TabIndex = 3;
            btnDatos.Text = "Mostrar datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(258, 13);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(37, 15);
            lblSuma.TabIndex = 4;
            lblSuma.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(258, 31);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 5;
            // 
            // lblPares
            // 
            lblPares.AutoSize = true;
            lblPares.Location = new Point(258, 80);
            lblPares.Name = "lblPares";
            lblPares.Size = new Size(35, 15);
            lblPares.TabIndex = 6;
            lblPares.Text = "Pares";
            // 
            // txtPares
            // 
            txtPares.Location = new Point(258, 98);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 7;
            // 
            // lblImpares
            // 
            lblImpares.AutoSize = true;
            lblImpares.Location = new Point(152, 80);
            lblImpares.Name = "lblImpares";
            lblImpares.Size = new Size(49, 15);
            lblImpares.TabIndex = 8;
            lblImpares.Text = "Impares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(152, 98);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 9;
            // 
            // Form12PracticaColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 213);
            Controls.Add(txtImpares);
            Controls.Add(lblImpares);
            Controls.Add(txtPares);
            Controls.Add(lblPares);
            Controls.Add(txtSuma);
            Controls.Add(lblSuma);
            Controls.Add(btnDatos);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(lblNumeros);
            Name = "Form12PracticaColeccionNumeros";
            Text = "Form12PracticaColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeros;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnDatos;
        private Label lblSuma;
        private TextBox txtSuma;
        private Label lblPares;
        private TextBox txtPares;
        private Label lblImpares;
        private TextBox txtImpares;
    }
}