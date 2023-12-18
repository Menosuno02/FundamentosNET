namespace Fundamentos
{
    partial class Form01SumarNumeros
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
            lblNum1 = new Label();
            txtNum1 = new TextBox();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            btnSumarNumeros = new Button();
            lblResult = new Label();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(12, 9);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(60, 15);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Número 1";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(12, 27);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 1;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(138, 9);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(60, 15);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Número 2";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(138, 27);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 3;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(12, 56);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(226, 23);
            btnSumarNumeros.TabIndex = 4;
            btnSumarNumeros.Text = "Sumar números";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 90);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Resultado";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(77, 87);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(161, 23);
            txtResult.TabIndex = 6;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(254, 129);
            Controls.Add(txtResult);
            Controls.Add(lblResult);
            Controls.Add(btnSumarNumeros);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private TextBox txtNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Button btnSumarNumeros;
        private Label lblResult;
        private TextBox txtResult;
    }
}