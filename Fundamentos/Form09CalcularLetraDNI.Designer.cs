namespace Fundamentos
{
    partial class Form09CalcularLetraDNI
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
            lblDNI = new Label();
            txtDNI = new TextBox();
            btnCalcularLetra = new Button();
            txtLetra = new TextBox();
            lblLetra = new Label();
            SuspendLayout();
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(12, 9);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(27, 15);
            lblDNI.TabIndex = 0;
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(12, 27);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(143, 23);
            txtDNI.TabIndex = 1;
            // 
            // btnCalcularLetra
            // 
            btnCalcularLetra.Location = new Point(12, 56);
            btnCalcularLetra.Name = "btnCalcularLetra";
            btnCalcularLetra.Size = new Size(143, 23);
            btnCalcularLetra.TabIndex = 2;
            btnCalcularLetra.Text = "Calcular letra";
            btnCalcularLetra.UseVisualStyleBackColor = true;
            btnCalcularLetra.Click += btnCalcularLetra_Click;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(12, 122);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(143, 23);
            txtLetra.TabIndex = 3;
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Location = new Point(12, 104);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(33, 15);
            lblLetra.TabIndex = 4;
            lblLetra.Text = "Letra";
            // 
            // Form09CalcularLetraDNI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(174, 161);
            Controls.Add(lblLetra);
            Controls.Add(txtLetra);
            Controls.Add(btnCalcularLetra);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Name = "Form09CalcularLetraDNI";
            Text = "Form09CalcularLetraDNI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDNI;
        private TextBox txtDNI;
        private Button btnCalcularLetra;
        private TextBox txtLetra;
        private Label lblLetra;
    }
}