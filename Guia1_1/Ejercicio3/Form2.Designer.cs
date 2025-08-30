namespace Ejercicio3
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(45, 182);
            button1.Name = "button1";
            button1.Size = new Size(126, 41);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(216, 182);
            button2.Name = "button2";
            button2.Size = new Size(126, 41);
            button2.TabIndex = 1;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 31);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Dias";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 98);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 3;
            label2.Text = "Cantidad Autos ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(173, 24);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 252);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label label1;
        private Label label2;
        public Button button1;
        public TextBox textBox1;
        public NumericUpDown numericUpDown1;
    }
}