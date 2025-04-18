namespace ALGORITIMO7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_10_de_abr__de_2025__20_19_44;
            pictureBox2.Location = new Point(911, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += checkBox1_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.ChatGPT_Image_10_de_abr__de_2025__20_07_09__1_;
            pictureBox3.Location = new Point(955, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 35);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(459, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 24);
            textBox1.TabIndex = 3;
            textBox1.TabIndexChanged += textBox1_TextChanged;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(459, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 24);
            textBox2.TabIndex = 4;
            textBox2.TabIndexChanged += textBox2_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(439, 266);
            button1.Name = "button1";
            button1.Size = new Size(293, 62);
            button1.TabIndex = 5;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(468, 208);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(186, 29);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Lembrar Usuário";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(458, 81);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(458, 143);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 8;
            label2.Text = "Senha";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.DisabledLinkColor = Color.DimGray;
            linkLabel1.LinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.Location = new Point(519, 143);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(151, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Recuperar Acesso";
            linkLabel1.VisitedLinkColor = Color.FromArgb(192, 0, 0);
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Click += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.adc581cdf930efa7b1818c640c2a73ee;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(993, 559);
            Controls.Add(linkLabel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabel1;
    }
}
