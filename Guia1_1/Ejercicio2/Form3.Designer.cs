namespace Ejercicio2
{
    partial class Form3
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
            tbIniciarH = new TextBox();
            tbIniciarM = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            tbAsientos = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 0;
            label1.Text = "Hora de partida (HH:MM)";
            // 
            // tbIniciarH
            // 
            tbIniciarH.Location = new Point(215, 9);
            tbIniciarH.Name = "tbIniciarH";
            tbIniciarH.Size = new Size(32, 27);
            tbIniciarH.TabIndex = 1;
            // 
            // tbIniciarM
            // 
            tbIniciarM.Location = new Point(271, 9);
            tbIniciarM.Name = "tbIniciarM";
            tbIniciarM.Size = new Size(32, 27);
            tbIniciarM.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 12);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 3;
            label2.Text = ":";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(70, 100);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Iniciar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 53);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 5;
            label3.Text = "Asientos";
            // 
            // tbAsientos
            // 
            tbAsientos.Location = new Point(215, 50);
            tbAsientos.Name = "tbAsientos";
            tbAsientos.Size = new Size(32, 27);
            tbAsientos.TabIndex = 6;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(271, 100);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 141);
            Controls.Add(button2);
            Controls.Add(tbAsientos);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(tbIniciarM);
            Controls.Add(tbIniciarH);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Inicio de viaje ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        public TextBox tbIniciarH;
        public TextBox tbIniciarM;
        public Button button1;
        public Button button2;
        public TextBox tbAsientos;
    }
}