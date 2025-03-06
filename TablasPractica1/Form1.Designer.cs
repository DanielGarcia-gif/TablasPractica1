namespace TablasPractica1
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
            butTitulos = new Button();
            butEmpleados = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // butTitulos
            // 
            butTitulos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            butTitulos.Location = new Point(18, 13);
            butTitulos.Name = "butTitulos";
            butTitulos.Size = new Size(100, 32);
            butTitulos.TabIndex = 0;
            butTitulos.Text = "Titulos";
            butTitulos.UseVisualStyleBackColor = true;
            butTitulos.Click += butTitulos_Click;
            // 
            // butEmpleados
            // 
            butEmpleados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            butEmpleados.Location = new Point(328, 13);
            butEmpleados.Name = "butEmpleados";
            butEmpleados.Size = new Size(109, 32);
            butEmpleados.TabIndex = 1;
            butEmpleados.Text = "Empleados";
            butEmpleados.UseVisualStyleBackColor = true;
            butEmpleados.Click += butEmpleados_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(178, 34);
            label1.Name = "label1";
            label1.Size = new Size(277, 32);
            label1.TabIndex = 2;
            label1.Text = "Modificacion de Tablas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Location = new Point(12, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 10);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(12, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(620, 10);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(butTitulos);
            panel3.Controls.Add(butEmpleados);
            panel3.Location = new Point(12, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(620, 56);
            panel3.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button2.Location = new Point(492, 13);
            button2.Name = "button2";
            button2.Size = new Size(109, 32);
            button2.TabIndex = 9;
            button2.Text = "Trabajos";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            button1.Location = new Point(166, 13);
            button1.Name = "button1";
            button1.Size = new Size(109, 32);
            button1.TabIndex = 8;
            button1.Text = "Autores";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(340, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.titles;
            pictureBox2.Location = new Point(30, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngtree_author_of_professional_imagination_illustration_series_png_image_4265200;
            pictureBox3.Location = new Point(178, 182);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(109, 115);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._2696531;
            pictureBox4.Location = new Point(504, 182);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(109, 115);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 325);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Inicio";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butTitulos;
        private Button butEmpleados;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private Button button2;
        private PictureBox pictureBox4;
    }
}
