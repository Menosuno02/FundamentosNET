namespace Fundamentos
{
    partial class Form17SumarBotones
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
            lblSuma = new Label();
            txtSuma = new TextBox();
            btnIniciar = new Button();
            panelBotones = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(12, 15);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(43, 15);
            lblSuma.TabIndex = 0;
            lblSuma.Text = "Suma: ";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(56, 12);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 1;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(177, 12);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 23);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar app";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // panelBotones
            // 
            panelBotones.BorderStyle = BorderStyle.FixedSingle;
            panelBotones.Controls.Add(button6);
            panelBotones.Controls.Add(button5);
            panelBotones.Controls.Add(button4);
            panelBotones.Controls.Add(button3);
            panelBotones.Controls.Add(button2);
            panelBotones.Controls.Add(button1);
            panelBotones.Location = new Point(12, 41);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(249, 329);
            panelBotones.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(165, 3);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(84, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(3, 32);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(84, 32);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(165, 32);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form17SumarBotones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelBotones);
            Controls.Add(btnIniciar);
            Controls.Add(txtSuma);
            Controls.Add(lblSuma);
            Name = "Form17SumarBotones";
            Text = "Form17SumarBotones";
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSuma;
        private TextBox txtSuma;
        private Button btnIniciar;
        private Panel panelBotones;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}