namespace Fundamentos
{
    partial class Form14Metodos
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
            lblNumero = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            lblMouse = new Label();
            label1 = new Label();
            txtNúmeros = new TextBox();
            label2 = new Label();
            txtLetras = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(12, 9);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(12, 27);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 70);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(12, 108);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(75, 23);
            btnDobleValor.TabIndex = 4;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(12, 137);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(75, 42);
            btnDobleReferencia.TabIndex = 5;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(12, 185);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(75, 43);
            btnObjetoReferencia.TabIndex = 6;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // lblMouse
            // 
            lblMouse.BackColor = SystemColors.HotTrack;
            lblMouse.BorderStyle = BorderStyle.Fixed3D;
            lblMouse.ForeColor = SystemColors.Control;
            lblMouse.Location = new Point(110, 108);
            lblMouse.Name = "lblMouse";
            lblMouse.Size = new Size(133, 220);
            lblMouse.TabIndex = 7;
            lblMouse.Text = "lblMouse";
            lblMouse.MouseMove += lblMouse_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 8;
            label1.Text = "Solo números";
            // 
            // txtNúmeros
            // 
            txtNúmeros.Location = new Point(138, 27);
            txtNúmeros.Name = "txtNúmeros";
            txtNúmeros.Size = new Size(100, 23);
            txtNúmeros.TabIndex = 9;
            txtNúmeros.KeyPress += txtNúmeros_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 10;
            label2.Text = "Sólo letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(138, 71);
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(100, 23);
            txtLetras.TabIndex = 11;
            txtLetras.KeyPress += txtLetras_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 346);
            Controls.Add(txtLetras);
            Controls.Add(label2);
            Controls.Add(txtNúmeros);
            Controls.Add(label1);
            Controls.Add(lblMouse);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            FormClosed += Form14Metodos_FormClosed;
            Load += Form14Metodos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label lblMouse;
        private Label label1;
        private TextBox txtNúmeros;
        private Label label2;
        private TextBox txtLetras;
    }
}