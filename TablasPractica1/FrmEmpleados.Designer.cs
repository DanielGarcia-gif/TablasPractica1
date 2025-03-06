namespace TablasPractica1
{
    partial class FrmEmpleados
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
            dgvEmpleados = new DataGridView();
            butInsertar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(32, 155);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(893, 359);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // butInsertar
            // 
            butInsertar.BackgroundImage = Properties.Resources.empAdd;
            butInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            butInsertar.Location = new Point(447, 546);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(82, 70);
            butInsertar.TabIndex = 1;
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(37, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 10);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(32, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 10);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(16, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 359);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Location = new Point(931, 155);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 359);
            panel4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 41);
            label1.Name = "label1";
            label1.Size = new Size(498, 55);
            label1.TabIndex = 6;
            label1.Text = "Tabla de Empleados";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.emp;
            pictureBox1.Location = new Point(652, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(949, 628);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(butInsertar);
            Controls.Add(dgvEmpleados);
            Name = "FrmEmpleados";
            Text = "Tabla Empleados";
            Activated += FrmEmpleados_Activated;
            Load += FrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button butInsertar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox1;
    }
}