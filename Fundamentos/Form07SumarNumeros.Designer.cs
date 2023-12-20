namespace Fundamentos
{
    partial class Form07SumarNumeros
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
            lblSecuencia = new Label();
            txtSecuencia = new TextBox();
            btnSumar = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblSecuencia
            // 
            lblSecuencia.AutoSize = true;
            lblSecuencia.Location = new Point(12, 9);
            lblSecuencia.Name = "lblSecuencia";
            lblSecuencia.Size = new Size(110, 15);
            lblSecuencia.TabIndex = 0;
            lblSecuencia.Text = "Secuencia números";
            // 
            // txtSecuencia
            // 
            txtSecuencia.Location = new Point(12, 27);
            txtSecuencia.Name = "txtSecuencia";
            txtSecuencia.Size = new Size(209, 23);
            txtSecuencia.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(12, 56);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(209, 23);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar secuencia";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 93);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 15);
            lblResult.TabIndex = 3;
            lblResult.Text = "Resultado";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 111);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(209, 23);
            txtResult.TabIndex = 4;
            // 
            // Form07SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 150);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(btnSumar);
            Controls.Add(txtSecuencia);
            Controls.Add(lblSecuencia);
            Name = "Form07SumarNumeros";
            Text = "Form07SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSecuencia;
        private TextBox txtSecuencia;
        private Button btnSumar;
        private Label lblResult;
        private TextBox txtResult;
    }
}