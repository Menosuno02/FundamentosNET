namespace Fundamentos
{
    partial class Form21TemperaturasClases
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
            lstMeses = new ListBox();
            btnGenerarTemp = new Button();
            btnDatos = new Button();
            label2 = new Label();
            txtMax = new TextBox();
            label3 = new Label();
            txtMin = new TextBox();
            label4 = new Label();
            txtMedia = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Meses";
            // 
            // lstMeses
            // 
            lstMeses.FormattingEnabled = true;
            lstMeses.ItemHeight = 15;
            lstMeses.Location = new Point(12, 27);
            lstMeses.Name = "lstMeses";
            lstMeses.Size = new Size(120, 229);
            lstMeses.TabIndex = 1;
            // 
            // btnGenerarTemp
            // 
            btnGenerarTemp.Location = new Point(154, 12);
            btnGenerarTemp.Name = "btnGenerarTemp";
            btnGenerarTemp.Size = new Size(107, 23);
            btnGenerarTemp.TabIndex = 2;
            btnGenerarTemp.Text = "Generar temp";
            btnGenerarTemp.UseVisualStyleBackColor = true;
            btnGenerarTemp.Click += btnGenerarTemp_Click;
            // 
            // btnDatos
            // 
            btnDatos.Location = new Point(154, 41);
            btnDatos.Name = "btnDatos";
            btnDatos.Size = new Size(107, 23);
            btnDatos.TabIndex = 3;
            btnDatos.Text = "Mostrar datos";
            btnDatos.UseVisualStyleBackColor = true;
            btnDatos.Click += btnDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 83);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 4;
            label2.Text = "Temp. máxima";
            // 
            // txtMax
            // 
            txtMax.ForeColor = Color.Red;
            txtMax.Location = new Point(154, 101);
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(107, 23);
            txtMax.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 144);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Temp. mínima";
            // 
            // txtMin
            // 
            txtMin.ForeColor = SystemColors.MenuHighlight;
            txtMin.Location = new Point(154, 162);
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(107, 23);
            txtMin.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 207);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Media mensual";
            // 
            // txtMedia
            // 
            txtMedia.Location = new Point(154, 225);
            txtMedia.Name = "txtMedia";
            txtMedia.Size = new Size(107, 23);
            txtMedia.TabIndex = 9;
            // 
            // Form21TemperaturasClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 287);
            Controls.Add(txtMedia);
            Controls.Add(label4);
            Controls.Add(txtMin);
            Controls.Add(label3);
            Controls.Add(txtMax);
            Controls.Add(label2);
            Controls.Add(btnDatos);
            Controls.Add(btnGenerarTemp);
            Controls.Add(lstMeses);
            Controls.Add(label1);
            Name = "Form21TemperaturasClases";
            Text = "Form21TemperaturasClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstMeses;
        private Button btnGenerarTemp;
        private Button btnDatos;
        private Label label2;
        private TextBox txtMax;
        private Label label3;
        private TextBox txtMin;
        private Label label4;
        private TextBox txtMedia;
    }
}