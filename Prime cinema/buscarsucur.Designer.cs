namespace Prime_cinema
{
    partial class buscarsucur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(buscarsucur));
            panelsucu = new Panel();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panelsucu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelsucu
            // 
            panelsucu.Controls.Add(label1);
            panelsucu.Controls.Add(pictureBox3);
            panelsucu.Controls.Add(textBox2);
            panelsucu.Controls.Add(pictureBox2);
            panelsucu.Controls.Add(textBox1);
            panelsucu.Controls.Add(pictureBox1);
            panelsucu.Location = new Point(1, -1);
            panelsucu.Name = "panelsucu";
            panelsucu.Size = new Size(799, 453);
            panelsucu.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(224, 76);
            label1.Name = "label1";
            label1.Size = new Size(358, 47);
            label1.TabIndex = 21;
            label1.Text = "Sucursales disponibles";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-66, 76);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(904, 47);
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 144);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(776, 296);
            textBox2.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 128, 0);
            pictureBox2.BackgroundImage = Properties.Resources.boton_amarillo;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(693, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ControlDarkDark;
            textBox1.Location = new Point(10, 14);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(636, 35);
            textBox1.TabIndex = 17;
            textBox1.Text = "Buscar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-66, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(896, 67);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buscarsucur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelsucu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "buscarsucur";
            Text = "buscarsucur";
            panelsucu.ResumeLayout(false);
            panelsucu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelsucu;
        private Label label1;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
    }
}