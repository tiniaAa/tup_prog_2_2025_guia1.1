namespace Ejercicio2
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            tbDescienden = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbHH = new TextBox();
            tbMMsalida = new TextBox();
            tbMM = new TextBox();
            tbHHsalida = new TextBox();
            tbAscienden = new TextBox();
            btnCancelarViaje = new Button();
            btnIniciarViaje = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbDescienden);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbHH);
            groupBox1.Controls.Add(tbMMsalida);
            groupBox1.Controls.Add(tbMM);
            groupBox1.Controls.Add(tbHHsalida);
            groupBox1.Controls.Add(tbAscienden);
            groupBox1.Controls.Add(btnCancelarViaje);
            groupBox1.Controls.Add(btnIniciarViaje);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 293);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Parada";
            // 
            // tbDescienden
            // 
            tbDescienden.Location = new Point(231, 179);
            tbDescienden.Name = "tbDescienden";
            tbDescienden.Size = new Size(55, 27);
            tbDescienden.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 69);
            label6.Name = "label6";
            label6.Size = new Size(12, 20);
            label6.TabIndex = 12;
            label6.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(249, 25);
            label5.Name = "label5";
            label5.Size = new Size(12, 20);
            label5.TabIndex = 11;
            label5.Text = ":";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(108, 182);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 10;
            label4.Text = "Descienden";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 129);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Ascienden ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 72);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 8;
            label2.Text = "Salida (HH:MM)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 28);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 7;
            label1.Text = "LLegada (HH:MM)";
            // 
            // tbHH
            // 
            tbHH.Location = new Point(201, 25);
            tbHH.Name = "tbHH";
            tbHH.Size = new Size(43, 27);
            tbHH.TabIndex = 6;
            // 
            // tbMMsalida
            // 
            tbMMsalida.Location = new Point(268, 66);
            tbMMsalida.Name = "tbMMsalida";
            tbMMsalida.Size = new Size(43, 27);
            tbMMsalida.TabIndex = 5;
            // 
            // tbMM
            // 
            tbMM.Location = new Point(267, 25);
            tbMM.Name = "tbMM";
            tbMM.Size = new Size(43, 27);
            tbMM.TabIndex = 4;
            tbMM.TextChanged += textBox3_TextChanged;
            // 
            // tbHHsalida
            // 
            tbHHsalida.Location = new Point(201, 66);
            tbHHsalida.Name = "tbHHsalida";
            tbHHsalida.Size = new Size(43, 27);
            tbHHsalida.TabIndex = 3;
            tbHHsalida.TextChanged += textBox2_TextChanged;
            // 
            // tbAscienden
            // 
            tbAscienden.Location = new Point(231, 126);
            tbAscienden.Name = "tbAscienden";
            tbAscienden.Size = new Size(55, 27);
            tbAscienden.TabIndex = 2;
            // 
            // btnCancelarViaje
            // 
            btnCancelarViaje.DialogResult = DialogResult.Cancel;
            btnCancelarViaje.Location = new Point(209, 231);
            btnCancelarViaje.Name = "btnCancelarViaje";
            btnCancelarViaje.Size = new Size(188, 44);
            btnCancelarViaje.TabIndex = 1;
            btnCancelarViaje.Text = "Cargar carga de parada";
            btnCancelarViaje.UseVisualStyleBackColor = true;
            // 
            // btnIniciarViaje
            // 
            btnIniciarViaje.DialogResult = DialogResult.OK;
            btnIniciarViaje.Location = new Point(10, 231);
            btnIniciarViaje.Name = "btnIniciarViaje";
            btnIniciarViaje.Size = new Size(131, 44);
            btnIniciarViaje.TabIndex = 0;
            btnIniciarViaje.Text = "Cargar Parada";
            btnIniciarViaje.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 316);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelarViaje;
        private Button btnIniciarViaje;
        public Label label6;
        public Label label5;
        public TextBox tbHH;
        public TextBox tbMMsalida;
        public TextBox tbMM;
        public TextBox tbHHsalida;
        public TextBox tbAscienden;
        public TextBox tbDescienden;
    }
}