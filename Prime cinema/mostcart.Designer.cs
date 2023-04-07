namespace Prime_cinema
{
    partial class mostcart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mostcart));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            panelmostrarcart = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-64, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(998, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(162, 23);
            label1.Name = "label1";
            label1.Size = new Size(513, 47);
            label1.TabIndex = 22;
            label1.Text = "Peliculas disponibles en cartelera";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 113);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(776, 296);
            textBox2.TabIndex = 23;
            // 
            // panelmostrarcart
            // 
            panelmostrarcart.Location = new Point(0, 0);
            panelmostrarcart.Name = "panelmostrarcart";
            panelmostrarcart.Size = new Size(800, 451);
            panelmostrarcart.TabIndex = 24;
            // 
            // mostcart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panelmostrarcart);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mostcart";
            Text = "mostcart";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox2;
        private Panel panelmostrarcart;
    }
}