namespace Fundamentos
{
    partial class Form20TestingClases
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
            lstDatosClases = new ListBox();
            btnCrearPersona = new Button();
            btnCrearEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Datos de clases";
            // 
            // lstDatosClases
            // 
            lstDatosClases.FormattingEnabled = true;
            lstDatosClases.ItemHeight = 15;
            lstDatosClases.Location = new Point(12, 27);
            lstDatosClases.Name = "lstDatosClases";
            lstDatosClases.Size = new Size(279, 289);
            lstDatosClases.TabIndex = 1;
            // 
            // btnCrearPersona
            // 
            btnCrearPersona.Location = new Point(12, 322);
            btnCrearPersona.Name = "btnCrearPersona";
            btnCrearPersona.Size = new Size(279, 23);
            btnCrearPersona.TabIndex = 2;
            btnCrearPersona.Text = "Crear persona";
            btnCrearPersona.UseVisualStyleBackColor = true;
            btnCrearPersona.Click += btnCrearPersona_Click;
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Location = new Point(12, 351);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(279, 23);
            btnCrearEmpleado.TabIndex = 3;
            btnCrearEmpleado.Text = "Crear empleado";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += btnCrearEmpleado_Click;
            // 
            // Form20TestingClases
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 388);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(btnCrearPersona);
            Controls.Add(lstDatosClases);
            Controls.Add(label1);
            Name = "Form20TestingClases";
            Text = "Form20TestingClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstDatosClases;
        private Button btnCrearPersona;
        private Button btnCrearEmpleado;
    }
}