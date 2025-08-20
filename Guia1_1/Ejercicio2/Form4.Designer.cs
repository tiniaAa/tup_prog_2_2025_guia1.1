namespace Ejercicio2
{
    partial class Form4
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
            lbxInforme = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbxInforme
            // 
            lbxInforme.FormattingEnabled = true;
            lbxInforme.Location = new Point(12, 12);
            lbxInforme.Name = "lbxInforme";
            lbxInforme.Size = new Size(291, 304);
            lbxInforme.TabIndex = 0;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(114, 328);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 369);
            Controls.Add(button1);
            Controls.Add(lbxInforme);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public ListBox lbxInforme;
    }
}