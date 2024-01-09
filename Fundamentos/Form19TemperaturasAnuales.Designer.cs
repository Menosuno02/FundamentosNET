namespace Fundamentos
{
    partial class Form19TemperaturasAnuales
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
            lstTemperaturas = new ListBox();
            label1 = new Label();
            btnGenerarMeses = new Button();
            btnDatos = new Button();
            label2 = new Label();
            txtTemperaturaMax = new TextBox();
            txtTemperaturaMin = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtMedia = new TextBox();
            SuspendLayout();
            // 
            // lstTemperaturas
            // 
            lstTemperaturas.FormattingEnabled = true;
            lstTemperaturas.ItemHeight = 15;
            lstTemperaturas.Location = new Point(12, 27);
            lstTemperaturas.Name = "lstTemperaturas";
            lstTemperaturas.Size = new Size(120, 214);
            lstTemperaturas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Meses";
            // 
            // btnGenerarMeses
            // 
            btnGenerarMeses.Location = new Point(150, 12);
            btnGenerarMeses.Name = "btnGenerarMeses";
            btnGenerarMeses.Size = new Size(110, 23);
            btnGenerarMeses.TabIndex = 2;
            btnGenerarMeses.Text = "Generar meses";
            btnGenerarMeses.UseVisualStyleBackColor = true;
            btnGenerarMeses.Click += btnGenerarMeses_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(150, 41);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(110, 23);
            btnDatos.TabIndex = 3;
            btnDatos.Text = "Mostrar datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 84);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 4;
            label2.Text = "Temperatura máxima";
            // 
            // txtTemperaturaMax
            // 
            txtTemperaturaMax.ForeColor = Color.Red;
            txtTemperaturaMax.Location = new Point(150, 102);
            txtTemperaturaMax.Name = "txtTemperaturaMax";
            txtTemperaturaMax.Size = new Size(119, 23);
            txtTemperaturaMax.TabIndex = 5;
            // 
            // txtTemperaturaMin
            // 
            txtTemperaturaMin.ForeColor = SystemColors.MenuHighlight;
            txtTemperaturaMin.Location = new Point(150, 163);
            txtTemperaturaMin.Name = "txtTemperaturaMin";
            txtTemperaturaMin.Size = new Size(117, 23);
            txtTemperaturaMin.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(150, 145);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 7;
            label3.Text = "Temperatura mínima";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(150, 203);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 9;
            label4.Text = "Media anual";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(150, 221);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(117, 23);
            txtMedia.TabIndex = 8;
            // 
            // Form19TemperaturasAnuales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 277);
            Controls.Add(label4);
            Controls.Add(txtMedia);
            Controls.Add(label3);
            Controls.Add(txtTemperaturaMin);
            Controls.Add(txtTemperaturaMax);
            Controls.Add(label2);
            Controls.Add(btnDatos);
            Controls.Add(btnGenerarMeses);
            Controls.Add(label1);
            Controls.Add(lstTemperaturas);
            Name = "Form19TemperaturasAnuales";
            Text = "Form19TemperaturasAnuales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstTemperaturas;
        private Label label1;
        private Button btnGenerarMeses;
        private Button btnDatos;
        private Label label2;
        private TextBox txtTemperaturaMax;
        private TextBox txtTemperaturaMin;
        private Label label3;
        private Label label4;
        private TextBox txtMedia;
    }
}