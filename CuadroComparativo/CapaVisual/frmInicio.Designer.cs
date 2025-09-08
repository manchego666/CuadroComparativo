namespace CuadroComparativo
{
    partial class frmInicio
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
            pictureBox1 = new PictureBox();
            btnJugar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.ChatGPT_Image_7_sept_2025__07_53_35_p_m_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1322, 929);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.FromArgb(0, 0, 64);
            btnJugar.FlatStyle = FlatStyle.Popup;
            btnJugar.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJugar.ForeColor = Color.Cyan;
            btnJugar.Location = new Point(924, 843);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(176, 71);
            btnJugar.TabIndex = 1;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(0, 0, 64);
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.Cyan;
            btnSalir.Location = new Point(1133, 843);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(176, 71);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 926);
            Controls.Add(btnSalir);
            Controls.Add(btnJugar);
            Controls.Add(pictureBox1);
            Name = "frmInicio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnJugar;
        private Button btnSalir;
    }
}
