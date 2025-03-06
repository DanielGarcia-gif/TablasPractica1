namespace TablasPractica1
{
    partial class FrmTitulos
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
            dgvTitulos = new DataGridView();
            butInsertar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvTitulos
            // 
            dgvTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulos.Location = new Point(23, 122);
            dgvTitulos.Name = "dgvTitulos";
            dgvTitulos.Size = new Size(1038, 291);
            dgvTitulos.TabIndex = 0;
            dgvTitulos.CellContentClick += dgvTitulos_CellContentClick;
            // 
            // butInsertar
            // 
            butInsertar.BackgroundImage = Properties.Resources.pngwing_com__7_;
            butInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            butInsertar.Location = new Point(506, 458);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(82, 70);
            butInsertar.TabIndex = 1;
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 31);
            label1.Name = "label1";
            label1.Size = new Size(395, 55);
            label1.TabIndex = 7;
            label1.Text = "Tabla de Titulos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(23, 419);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 10);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(23, 106);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 10);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(7, 122);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 291);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Location = new Point(1066, 122);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 291);
            panel4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.titles;
            pictureBox1.Location = new Point(701, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // FrmTitulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1086, 559);
            Controls.Add(pictureBox1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(butInsertar);
            Controls.Add(dgvTitulos);
            Name = "FrmTitulos";
            Text = "Tabla de Titulos";
            Activated += FrmTitulos_Activated;
            Load += FrmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTitulos;
        private Button butInsertar;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
    }
}