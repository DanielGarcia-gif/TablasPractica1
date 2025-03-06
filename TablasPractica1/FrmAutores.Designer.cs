namespace TablasPractica1
{
    partial class FrmAutores
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
            dgvAutors = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAutors).BeginInit();
            SuspendLayout();
            // 
            // dgvAutors
            // 
            dgvAutors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutors.Cursor = Cursors.Hand;
            dgvAutors.Location = new Point(54, 98);
            dgvAutors.Margin = new Padding(3, 2, 3, 2);
            dgvAutors.Name = "dgvAutors";
            dgvAutors.ReadOnly = true;
            dgvAutors.RowHeadersWidth = 51;
            dgvAutors.Size = new Size(656, 302);
            dgvAutors.TabIndex = 1;
            dgvAutors.CellContentClick += dgvAutors_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 65);
            label1.TabIndex = 2;
            label1.Text = "Tabla de Autores";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(54, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(656, 15);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(54, 405);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 15);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(35, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(13, 302);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Location = new Point(716, 109);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 291);
            panel4.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(348, 437);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 487);
            Controls.Add(button1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(dgvAutors);
            Name = "FrmAutores";
            Text = "Tabla de Autores";
            Activated += FrmAutores_Activated;
            Load += FrmAutores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAutors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAutors;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
    }
}