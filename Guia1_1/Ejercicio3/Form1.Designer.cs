namespace Ejercicio3
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
            lbVer = new ListBox();
            btnRegistrarPeaje = new Button();
            btnResumen = new Button();
            SuspendLayout();
            // 
            // lbVer
            // 
            lbVer.FormattingEnabled = true;
            lbVer.Location = new Point(23, 23);
            lbVer.Name = "lbVer";
            lbVer.Size = new Size(304, 404);
            lbVer.TabIndex = 0;
            // 
            // btnRegistrarPeaje
            // 
            btnRegistrarPeaje.Location = new Point(333, 126);
            btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            btnRegistrarPeaje.Size = new Size(177, 50);
            btnRegistrarPeaje.TabIndex = 1;
            btnRegistrarPeaje.Text = "Registrar Peaje";
            btnRegistrarPeaje.UseVisualStyleBackColor = true;
            btnRegistrarPeaje.Click += btnRegistrarPeaje_Click;
            // 
            // btnResumen
            // 
            btnResumen.Location = new Point(333, 261);
            btnResumen.Name = "btnResumen";
            btnResumen.Size = new Size(177, 50);
            btnResumen.TabIndex = 2;
            btnResumen.Text = "Ver Resumen";
            btnResumen.UseVisualStyleBackColor = true;
            btnResumen.Click += btnResumen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(btnResumen);
            Controls.Add(btnRegistrarPeaje);
            Controls.Add(lbVer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbVer;
        private Button btnRegistrarPeaje;
        private Button btnResumen;
    }
}
