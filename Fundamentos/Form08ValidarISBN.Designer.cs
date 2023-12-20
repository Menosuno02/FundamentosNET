namespace Fundamentos
{
    partial class Form08ValidarISBN
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
            lblISBN = new Label();
            txtISBN = new TextBox();
            btnValidar = new Button();
            txtValidez = new TextBox();
            SuspendLayout();
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(12, 9);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(32, 15);
            lblISBN.TabIndex = 0;
            lblISBN.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(12, 27);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(174, 23);
            txtISBN.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(12, 56);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(174, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtValidez
            // 
            txtValidez.Location = new Point(12, 96);
            txtValidez.Name = "txtValidez";
            txtValidez.Size = new Size(174, 23);
            txtValidez.TabIndex = 3;
            // 
            // Form08ValidarISBN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 138);
            Controls.Add(txtValidez);
            Controls.Add(btnValidar);
            Controls.Add(txtISBN);
            Controls.Add(lblISBN);
            Name = "Form08ValidarISBN";
            Text = "Form08ValidarISBN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblISBN;
        private TextBox txtISBN;
        private Button btnValidar;
        private TextBox txtValidez;
    }
}