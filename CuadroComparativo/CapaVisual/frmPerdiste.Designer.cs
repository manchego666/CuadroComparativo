namespace CuadroComparativo.CapaVisual
{
    partial class frmPerdiste
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
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            btnReintentar = new Button();
            lblAciertos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_7_sept_2025__11_32_23_p_m_;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(2016, 1700);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(81, 1494);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(539, 160);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReintentar
            // 
            btnReintentar.FlatStyle = FlatStyle.Popup;
            btnReintentar.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReintentar.Location = new Point(685, 1494);
            btnReintentar.Name = "btnReintentar";
            btnReintentar.Size = new Size(539, 160);
            btnReintentar.TabIndex = 2;
            btnReintentar.Text = "REINTENTAR";
            btnReintentar.UseVisualStyleBackColor = true;
            btnReintentar.Click += btnReintentar_Click;
            // 
            // lblAciertos
            // 
            lblAciertos.AutoSize = true;
            lblAciertos.BackColor = Color.Transparent;
            lblAciertos.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAciertos.Location = new Point(81, 1290);
            lblAciertos.Name = "lblAciertos";
            lblAciertos.Size = new Size(328, 86);
            lblAciertos.TabIndex = 3;
            lblAciertos.Text = "ACIERTOS:";
            // 
            // frmPerdiste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2015, 1699);
            Controls.Add(lblAciertos);
            Controls.Add(btnReintentar);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Name = "frmPerdiste";
            Text = "frmPerdiste";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnSalir;
        private Button btnReintentar;
        private Label lblAciertos;
    }
}