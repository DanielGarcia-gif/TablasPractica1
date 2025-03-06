namespace TablasPractica1
{
    partial class InsertarTrabajo
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
            txtMin = new TextBox();
            label4 = new Label();
            txtJob_desc = new TextBox();
            label3 = new Label();
            txtMax = new TextBox();
            label2 = new Label();
            txtJob_ID = new TextBox();
            label1 = new Label();
            butCancelar = new Button();
            butInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1300424804_612x612;
            pictureBox1.Location = new Point(259, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // txtMin
            // 
            txtMin.BackColor = Color.FromArgb(224, 224, 224);
            txtMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMin.Location = new Point(132, 91);
            txtMin.MaxLength = 3;
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(132, 73);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "Min level";
            // 
            // txtJob_desc
            // 
            txtJob_desc.BackColor = Color.FromArgb(224, 224, 224);
            txtJob_desc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtJob_desc.Location = new Point(132, 31);
            txtJob_desc.MaxLength = 50;
            txtJob_desc.Name = "txtJob_desc";
            txtJob_desc.Size = new Size(100, 23);
            txtJob_desc.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(132, 13);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 13;
            label3.Text = "Job_desc";
            // 
            // txtMax
            // 
            txtMax.BackColor = Color.FromArgb(224, 224, 224);
            txtMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMax.Location = new Point(12, 91);
            txtMax.MaxLength = 3;
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 11;
            label2.Text = "Max Level";
            // 
            // txtJob_ID
            // 
            txtJob_ID.BackColor = Color.Silver;
            txtJob_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtJob_ID.Location = new Point(12, 31);
            txtJob_ID.MaxLength = 5;
            txtJob_ID.Name = "txtJob_ID";
            txtJob_ID.ReadOnly = true;
            txtJob_ID.Size = new Size(100, 23);
            txtJob_ID.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 9;
            label1.Text = "Job_ID";
            // 
            // butCancelar
            // 
            butCancelar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_182401;
            butCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            butCancelar.Location = new Point(179, 137);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(95, 34);
            butCancelar.TabIndex = 18;
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // butInsertar
            // 
            butInsertar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_192348;
            butInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            butInsertar.Location = new Point(78, 137);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(95, 34);
            butInsertar.TabIndex = 19;
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // InsertarTrabajo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 183);
            Controls.Add(butInsertar);
            Controls.Add(butCancelar);
            Controls.Add(pictureBox1);
            Controls.Add(txtMin);
            Controls.Add(label4);
            Controls.Add(txtJob_desc);
            Controls.Add(label3);
            Controls.Add(txtMax);
            Controls.Add(label2);
            Controls.Add(txtJob_ID);
            Controls.Add(label1);
            Name = "InsertarTrabajo";
            Text = "Insertar Nuevo Trabajo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtMin;
        private Label label4;
        private TextBox txtJob_desc;
        private Label label3;
        private TextBox txtMax;
        private Label label2;
        private TextBox txtJob_ID;
        private Label label1;
        private Button butCancelar;
        private Button butInsertar;
    }
}