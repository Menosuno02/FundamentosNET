namespace Fundamentos
{
    partial class FormPrimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPulsar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(12, 56);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(119, 23);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsa este botón";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(119, 23);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // FormPrimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 221);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(btnPulsar);
            Name = "FormPrimer";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}