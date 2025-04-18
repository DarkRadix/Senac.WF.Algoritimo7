namespace ALGORITIMO7
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            panel2 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(365, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 156);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Location = new Point(249, 183);
            panel3.Name = "panel3";
            panel3.Size = new Size(539, 241);
            panel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-91, -66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(2, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 286);
            panel1.TabIndex = 8;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(75, 284);
            button2.Name = "button2";
            button2.Size = new Size(96, 97);
            button2.TabIndex = 7;
            button2.Text = "Mercado";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_10_de_abr__de_2025__20_07_09__1_;
            pictureBox2.Location = new Point(402, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_10_de_abr__de_2025__20_19_44;
            pictureBox3.Location = new Point(352, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(2, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(343, 118);
            panel4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(10, 21);
            button1.Name = "button1";
            button1.Size = new Size(296, 59);
            button1.TabIndex = 9;
            button1.Text = "Cardapio";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(10, 86);
            button3.Name = "button3";
            button3.Size = new Size(296, 59);
            button3.TabIndex = 10;
            button3.Text = "Pagto";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(10, 151);
            button4.Name = "button4";
            button4.Size = new Size(296, 59);
            button4.TabIndex = 11;
            button4.Text = "Entrega";
            button4.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 451);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Button button1;
        private Button button4;
        private Button button3;
    }
}