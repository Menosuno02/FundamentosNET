namespace Fundamentos
{
    partial class Form02PosicionColores
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
            lblPosicionX = new Label();
            txtPosicionX = new TextBox();
            lblPosicionY = new Label();
            txtPosicionY = new TextBox();
            btnPosicion = new Button();
            lblRojo = new Label();
            lblVerde = new Label();
            lblAzul = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnColor = new Button();
            SuspendLayout();
            // 
            // lblPosicionX
            // 
            lblPosicionX.AutoSize = true;
            lblPosicionX.Location = new Point(12, 9);
            lblPosicionX.Name = "lblPosicionX";
            lblPosicionX.Size = new Size(62, 15);
            lblPosicionX.TabIndex = 0;
            lblPosicionX.Text = "Posición X";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(12, 27);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 1;
            // 
            // lblPosicionY
            // 
            lblPosicionY.AutoSize = true;
            lblPosicionY.Location = new Point(136, 9);
            lblPosicionY.Name = "lblPosicionY";
            lblPosicionY.Size = new Size(62, 15);
            lblPosicionY.TabIndex = 2;
            lblPosicionY.Text = "Posición Y";
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(136, 27);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(12, 56);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(224, 23);
            btnPosicion.TabIndex = 4;
            btnPosicion.Text = "Cambiar posición botón";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // lblRojo
            // 
            lblRojo.AutoSize = true;
            lblRojo.Location = new Point(12, 98);
            lblRojo.Name = "lblRojo";
            lblRojo.Size = new Size(31, 15);
            lblRojo.TabIndex = 5;
            lblRojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(125, 98);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(36, 15);
            lblVerde.TabIndex = 6;
            lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            lblAzul.AutoSize = true;
            lblAzul.Location = new Point(240, 98);
            lblAzul.Name = "lblAzul";
            lblAzul.Size = new Size(30, 15);
            lblAzul.TabIndex = 7;
            lblAzul.Text = "Azul";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(12, 116);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(125, 116);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(98, 23);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(240, 116);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(12, 145);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(328, 23);
            btnColor.TabIndex = 11;
            btnColor.Text = "Cambiar color Form";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 186);
            Controls.Add(btnColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(lblAzul);
            Controls.Add(lblVerde);
            Controls.Add(lblRojo);
            Controls.Add(btnPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(lblPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(lblPosicionX);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosicionX;
        private TextBox txtPosicionX;
        private Label lblPosicionY;
        private TextBox txtPosicionY;
        private Button btnPosicion;
        private Label lblRojo;
        private Label lblVerde;
        private Label lblAzul;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnColor;
    }
}