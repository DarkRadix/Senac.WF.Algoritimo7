﻿namespace ALGORITIMO7
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
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            BTNClientes = new Button();
            BTNEntrega = new Button();
            BTNPagto = new Button();
            BTNCardapio = new Button();
            panel4 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
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
            pictureBox1.Location = new Point(-116, -97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 269);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(BTNClientes);
            panel1.Controls.Add(BTNEntrega);
            panel1.Controls.Add(BTNPagto);
            panel1.Controls.Add(BTNCardapio);
            panel1.Location = new Point(2, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 338);
            panel1.TabIndex = 8;
            // 
            // BTNClientes
            // 
            BTNClientes.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNClientes.Image = (Image)resources.GetObject("BTNClientes.Image");
            BTNClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BTNClientes.Location = new Point(10, 97);
            BTNClientes.Name = "BTNClientes";
            BTNClientes.Size = new Size(296, 71);
            BTNClientes.TabIndex = 12;
            BTNClientes.Text = "Clientes";
            BTNClientes.UseVisualStyleBackColor = true;
            // 
            // BTNEntrega
            // 
            BTNEntrega.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNEntrega.Image = (Image)resources.GetObject("BTNEntrega.Image");
            BTNEntrega.ImageAlign = ContentAlignment.MiddleLeft;
            BTNEntrega.Location = new Point(10, 254);
            BTNEntrega.Name = "BTNEntrega";
            BTNEntrega.Size = new Size(296, 73);
            BTNEntrega.TabIndex = 11;
            BTNEntrega.Text = "Entrega";
            BTNEntrega.UseVisualStyleBackColor = true;
            // 
            // BTNPagto
            // 
            BTNPagto.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNPagto.Image = (Image)resources.GetObject("BTNPagto.Image");
            BTNPagto.ImageAlign = ContentAlignment.MiddleLeft;
            BTNPagto.Location = new Point(10, 178);
            BTNPagto.Name = "BTNPagto";
            BTNPagto.Size = new Size(296, 70);
            BTNPagto.TabIndex = 10;
            BTNPagto.Text = "Pagto.";
            BTNPagto.UseVisualStyleBackColor = true;
            // 
            // BTNCardapio
            // 
            BTNCardapio.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNCardapio.Image = (Image)resources.GetObject("BTNCardapio.Image");
            BTNCardapio.ImageAlign = ContentAlignment.MiddleLeft;
            BTNCardapio.Location = new Point(10, 21);
            BTNCardapio.Name = "BTNCardapio";
            BTNCardapio.Size = new Size(296, 71);
            BTNCardapio.TabIndex = 9;
            BTNCardapio.Text = "Cardapio";
            BTNCardapio.UseVisualStyleBackColor = true;
            BTNCardapio.Click += BTNCardapio_Click;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button BTNClientes;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Button BTNCardapio;
        private Button BTNEntrega;
        private Button BTNPagto;
    }
}