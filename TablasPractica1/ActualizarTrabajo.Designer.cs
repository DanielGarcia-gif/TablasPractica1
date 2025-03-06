namespace TablasPractica1
{
    partial class ActualizarTrabajo
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
            label1 = new Label();
            txtJob_ID = new TextBox();
            txtMax = new TextBox();
            label2 = new Label();
            txtJob_desc = new TextBox();
            label3 = new Label();
            txtMin = new TextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            butActualizar = new Button();
            butEliminar = new Button();
            butCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Job_ID";
            // 
            // txtJob_ID
            // 
            txtJob_ID.BackColor = Color.Silver;
            txtJob_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtJob_ID.Location = new Point(15, 31);
            txtJob_ID.Name = "txtJob_ID";
            txtJob_ID.ReadOnly = true;
            txtJob_ID.Size = new Size(100, 23);
            txtJob_ID.TabIndex = 1;
            // 
            // txtMax
            // 
            txtMax.BackColor = Color.FromArgb(224, 224, 224);
            txtMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMax.Location = new Point(15, 91);
            txtMax.MaxLength = 3;
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(15, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Max Level";
            // 
            // txtJob_desc
            // 
            txtJob_desc.BackColor = Color.FromArgb(224, 224, 224);
            txtJob_desc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtJob_desc.Location = new Point(135, 31);
            txtJob_desc.MaxLength = 50;
            txtJob_desc.Name = "txtJob_desc";
            txtJob_desc.Size = new Size(100, 23);
            txtJob_desc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(135, 13);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Job_desc";
            // 
            // txtMin
            // 
            txtMin.BackColor = Color.FromArgb(224, 224, 224);
            txtMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMin.Location = new Point(135, 91);
            txtMin.MaxLength = 3;
            txtMin.Name = "txtMin";
            txtMin.Size = new Size(100, 23);
            txtMin.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(135, 73);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 6;
            label4.Text = "Min level";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1300424804_612x612;
            pictureBox1.Location = new Point(262, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // butActualizar
            // 
            butActualizar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_181945;
            butActualizar.BackgroundImageLayout = ImageLayout.Stretch;
            butActualizar.Location = new Point(29, 140);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(100, 34);
            butActualizar.TabIndex = 9;
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // butEliminar
            // 
            butEliminar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_163039;
            butEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            butEliminar.Location = new Point(135, 140);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(100, 34);
            butEliminar.TabIndex = 10;
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // butCancelar
            // 
            butCancelar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_182401;
            butCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            butCancelar.Location = new Point(241, 140);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(100, 34);
            butCancelar.TabIndex = 11;
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // ActualizarTrabajo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(381, 201);
            Controls.Add(butCancelar);
            Controls.Add(butEliminar);
            Controls.Add(butActualizar);
            Controls.Add(pictureBox1);
            Controls.Add(txtMin);
            Controls.Add(label4);
            Controls.Add(txtJob_desc);
            Controls.Add(label3);
            Controls.Add(txtMax);
            Controls.Add(label2);
            Controls.Add(txtJob_ID);
            Controls.Add(label1);
            Name = "ActualizarTrabajo";
            Text = "Actualizar Trabajo";
            Load += ActualizarTrabajo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtJob_ID;
        private TextBox txtMax;
        private Label label2;
        private TextBox txtJob_desc;
        private Label label3;
        private TextBox txtMin;
        private Label label4;
        private PictureBox pictureBox1;
        private Button butActualizar;
        private Button butEliminar;
        private Button butCancelar;
    }
}