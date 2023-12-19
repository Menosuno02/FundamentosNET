namespace Fundamentos
{
    partial class Form03DiaNacimiento
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
            lblDia = new Label();
            txtDia = new TextBox();
            lblMes = new Label();
            txtMes = new TextBox();
            lblAnyo = new Label();
            txtAnyo = new TextBox();
            btnDiaNacimiento = new Button();
            lblDiaSemana = new Label();
            txtDiaSemana = new TextBox();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(12, 9);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Día";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(12, 27);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 1;
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Location = new Point(118, 9);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(29, 15);
            lblMes.TabIndex = 2;
            lblMes.Text = "Mes";
            // 
            // txtMes
            // 
            txtMes.Location = new Point(118, 27);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 3;
            // 
            // lblAnyo
            // 
            lblAnyo.AutoSize = true;
            lblAnyo.Location = new Point(224, 9);
            lblAnyo.Name = "lblAnyo";
            lblAnyo.Size = new Size(29, 15);
            lblAnyo.TabIndex = 4;
            lblAnyo.Text = "Año";
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(224, 27);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(100, 23);
            txtAnyo.TabIndex = 5;
            // 
            // btnDiaNacimiento
            // 
            btnDiaNacimiento.Location = new Point(12, 56);
            btnDiaNacimiento.Name = "btnDiaNacimiento";
            btnDiaNacimiento.Size = new Size(312, 23);
            btnDiaNacimiento.TabIndex = 6;
            btnDiaNacimiento.Text = "Calcular día semana";
            btnDiaNacimiento.UseVisualStyleBackColor = true;
            btnDiaNacimiento.Click += btnDiaNacimiento_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(12, 89);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(68, 15);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "Día semana";
            // 
            // txtDiaSemana
            // 
            txtDiaSemana.Location = new Point(86, 85);
            txtDiaSemana.Name = "txtDiaSemana";
            txtDiaSemana.Size = new Size(238, 23);
            txtDiaSemana.TabIndex = 8;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 123);
            Controls.Add(txtDiaSemana);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnDiaNacimiento);
            Controls.Add(txtAnyo);
            Controls.Add(lblAnyo);
            Controls.Add(txtMes);
            Controls.Add(lblMes);
            Controls.Add(txtDia);
            Controls.Add(lblDia);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private TextBox txtDia;
        private Label lblMes;
        private TextBox txtMes;
        private Label lblAnyo;
        private TextBox txtAnyo;
        private Button btnDiaNacimiento;
        private Label lblDiaSemana;
        private TextBox txtDiaSemana;
    }
}