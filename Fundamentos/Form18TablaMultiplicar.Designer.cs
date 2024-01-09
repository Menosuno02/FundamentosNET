namespace Fundamentos
{
    partial class Form18TablaMultiplicar
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
            txtSuma = new TextBox();
            btnTabla = new Button();
            pnlTabla = new Panel();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            pnlTabla.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(12, 27);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 1;
            // 
            // btnTabla
            // 
            btnTabla.Location = new Point(12, 56);
            btnTabla.Name = "btnTabla";
            btnTabla.Size = new Size(100, 23);
            btnTabla.TabIndex = 2;
            btnTabla.Text = "Mostrar tabla";
            btnTabla.UseVisualStyleBackColor = true;
            btnTabla.Click += btnTabla_Click;
            // 
            // pnlTabla
            // 
            pnlTabla.Controls.Add(textBox4);
            pnlTabla.Controls.Add(textBox3);
            pnlTabla.Controls.Add(textBox2);
            pnlTabla.Location = new Point(118, 12);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(145, 183);
            pnlTabla.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(24, 77);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(24, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(24, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // Form18TablaMultiplicar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 207);
            Controls.Add(pnlTabla);
            Controls.Add(btnTabla);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Name = "Form18TablaMultiplicar";
            Text = "Form18TablaMultiplicar";
            pnlTabla.ResumeLayout(false);
            pnlTabla.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSuma;
        private Button btnTabla;
        private Panel pnlTabla;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}