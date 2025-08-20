namespace Ejercicio2
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnINICIAR = new Button();
            btnPARADAR = new Button();
            gbFinalizar = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            tbMM = new TextBox();
            tbHH = new TextBox();
            btnFinalizar = new Button();
            gbFinalizar.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnINICIAR
            // 
            btnINICIAR.Location = new Point(27, 21);
            btnINICIAR.Name = "btnINICIAR";
            btnINICIAR.Size = new Size(393, 49);
            btnINICIAR.TabIndex = 1;
            btnINICIAR.Text = "Iniciar viaje ";
            btnINICIAR.UseVisualStyleBackColor = true;
            btnINICIAR.Click += btnINICIAR_Click;
            // 
            // btnPARADAR
            // 
            btnPARADAR.Location = new Point(27, 91);
            btnPARADAR.Name = "btnPARADAR";
            btnPARADAR.Size = new Size(393, 49);
            btnPARADAR.TabIndex = 2;
            btnPARADAR.Text = "Ingresar parada ";
            btnPARADAR.UseVisualStyleBackColor = true;
            btnPARADAR.Click += btnPARADAR_Click;
            // 
            // gbFinalizar
            // 
            gbFinalizar.Controls.Add(label2);
            gbFinalizar.Controls.Add(label1);
            gbFinalizar.Controls.Add(tbMM);
            gbFinalizar.Controls.Add(tbHH);
            gbFinalizar.Controls.Add(btnFinalizar);
            gbFinalizar.Location = new Point(12, 166);
            gbFinalizar.Name = "gbFinalizar";
            gbFinalizar.Size = new Size(430, 164);
            gbFinalizar.TabIndex = 3;
            gbFinalizar.TabStop = false;
            gbFinalizar.Text = "Finalizar viaje ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(306, 47);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 4;
            label2.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 47);
            label1.Name = "label1";
            label1.Size = new Size(210, 20);
            label1.TabIndex = 3;
            label1.Text = "Hora de Finalizacion (HH:MM)";
            // 
            // tbMM
            // 
            tbMM.Location = new Point(324, 44);
            tbMM.Name = "tbMM";
            tbMM.Size = new Size(68, 27);
            tbMM.TabIndex = 2;
            // 
            // tbHH
            // 
            tbHH.Location = new Point(231, 44);
            tbHH.Name = "tbHH";
            tbHH.Size = new Size(68, 27);
            tbHH.TabIndex = 1;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(132, 93);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(167, 39);
            btnFinalizar.TabIndex = 0;
            btnFinalizar.Text = "Finalizar viaje ";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 334);
            Controls.Add(gbFinalizar);
            Controls.Add(btnPARADAR);
            Controls.Add(btnINICIAR);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbFinalizar.ResumeLayout(false);
            gbFinalizar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button btnINICIAR;
        private Button btnPARADAR;
        private GroupBox gbFinalizar;
        private Label label1;
        private TextBox tbMM;
        private TextBox tbHH;
        private Button btnFinalizar;
        private Label label2;
    }
}
