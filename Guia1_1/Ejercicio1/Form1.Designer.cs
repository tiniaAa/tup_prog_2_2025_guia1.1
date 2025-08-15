namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbMarca = new TextBox();
            tbTasa = new TextBox();
            tbVidaUtil = new TextBox();
            tbValor = new TextBox();
            nupModelo = new NumericUpDown();
            nupAño = new NumericUpDown();
            btnCalcular = new Button();
            btnCerrar = new Button();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nupModelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAño).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 22);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 63);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "Modelo(Año)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 103);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "Año a calcular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 140);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 3;
            label4.Text = " Valor de fabrica $";
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(167, 19);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(125, 27);
            tbMarca.TabIndex = 4;
            // 
            // tbTasa
            // 
            tbTasa.Location = new Point(496, 49);
            tbTasa.Name = "tbTasa";
            tbTasa.Size = new Size(125, 27);
            tbTasa.TabIndex = 5;
            // 
            // tbVidaUtil
            // 
            tbVidaUtil.Location = new Point(496, 90);
            tbVidaUtil.Name = "tbVidaUtil";
            tbVidaUtil.Size = new Size(125, 27);
            tbVidaUtil.TabIndex = 6;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(167, 140);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(125, 27);
            tbValor.TabIndex = 7;
            // 
            // nupModelo
            // 
            nupModelo.Location = new Point(167, 56);
            nupModelo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupModelo.Name = "nupModelo";
            nupModelo.Size = new Size(125, 27);
            nupModelo.TabIndex = 8;
            // 
            // nupAño
            // 
            nupAño.Location = new Point(167, 96);
            nupAño.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nupAño.Name = "nupAño";
            nupAño.Size = new Size(125, 27);
            nupAño.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.DialogResult = DialogResult.OK;
            btnCalcular.Location = new Point(167, 188);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(128, 44);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular Costos ";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(319, 188);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(128, 44);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(325, 56);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 12;
            label5.Text = "Tasa de depreciación ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(325, 93);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 13;
            label6.Text = "Vida Útil (Años)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 264);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnCerrar);
            Controls.Add(btnCalcular);
            Controls.Add(nupAño);
            Controls.Add(nupModelo);
            Controls.Add(tbValor);
            Controls.Add(tbVidaUtil);
            Controls.Add(tbTasa);
            Controls.Add(tbMarca);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nupModelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbMarca;
        private TextBox tbTasa;
        private TextBox tbVidaUtil;
        private TextBox tbValor;
        private NumericUpDown nupModelo;
        private NumericUpDown nupAño;
        private Button btnCalcular;
        private Button btnCerrar;
        private Label label5;
        private Label label6;
    }
}
