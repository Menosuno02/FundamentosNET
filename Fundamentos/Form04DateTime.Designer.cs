namespace Fundamentos
{
    partial class Form04DateTime
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
            lblFecha = new Label();
            txtFecha = new TextBox();
            chkCambiarFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            groupBox1 = new GroupBox();
            btnIncrementar = new Button();
            txtIncrementar = new TextBox();
            lblIncrementar = new Label();
            lblNuevaFecha = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(12, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(73, 15);
            lblFecha.TabIndex = 0;
            lblFecha.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(12, 27);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(292, 23);
            txtFecha.TabIndex = 1;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(12, 56);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(149, 19);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "Cambiar formato fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(6, 22);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Días";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(6, 47);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(6, 72);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncrementar);
            groupBox1.Controls.Add(lblIncrementar);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Controls.Add(rdbAnyos);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Location = new Point(12, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 105);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Incrementar fecha";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(129, 68);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(157, 23);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtIncrementar
            // 
            txtIncrementar.Location = new Point(129, 42);
            txtIncrementar.Name = "txtIncrementar";
            txtIncrementar.Size = new Size(157, 23);
            txtIncrementar.TabIndex = 7;
            // 
            // lblIncrementar
            // 
            lblIncrementar.AutoSize = true;
            lblIncrementar.Location = new Point(129, 24);
            lblIncrementar.Name = "lblIncrementar";
            lblIncrementar.Size = new Size(68, 15);
            lblIncrementar.TabIndex = 6;
            lblIncrementar.Text = "Incremento";
            // 
            // lblNuevaFecha
            // 
            lblNuevaFecha.AutoSize = true;
            lblNuevaFecha.Location = new Point(12, 198);
            lblNuevaFecha.Name = "lblNuevaFecha";
            lblNuevaFecha.Size = new Size(73, 15);
            lblNuevaFecha.TabIndex = 7;
            lblNuevaFecha.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(12, 216);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(292, 23);
            txtNuevaFecha.TabIndex = 8;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 257);
            Controls.Add(txtNuevaFecha);
            Controls.Add(lblNuevaFecha);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFecha);
            Controls.Add(lblFecha);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFecha;
        private TextBox txtFecha;
        private CheckBox chkCambiarFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private GroupBox groupBox1;
        private Button btnIncrementar;
        private TextBox txtIncrementar;
        private Label lblIncrementar;
        private Label lblNuevaFecha;
        private TextBox txtNuevaFecha;
    }
}