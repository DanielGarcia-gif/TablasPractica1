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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // butTitulos
            // 
            butTitulos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            butTitulos.Location = new Point(18, 13);
            butTitulos.Name = "butTitulos";
            butTitulos.Size = new Size(203, 32);
            butTitulos.TabIndex = 0;
            butTitulos.Text = "Titulos";
            butTitulos.UseVisualStyleBackColor = true;
            butTitulos.Click += butTitulos_Click;
            // 
            // butEmpleados
            // 
            butEmpleados.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            butEmpleados.Location = new Point(237, 13);
            butEmpleados.Name = "butEmpleados";
            butEmpleados.Size = new Size(200, 32);
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
            label1.Location = new Point(103, 34);
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
            panel1.Size = new Size(449, 10);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(12, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(449, 10);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(butTitulos);
            panel3.Controls.Add(butEmpleados);
            panel3.Location = new Point(12, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(449, 56);
            panel3.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.employee;
            pictureBox1.Location = new Point(297, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.titles;
            pictureBox2.Location = new Point(83, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 307);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}
