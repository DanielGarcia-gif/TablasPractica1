namespace TablasPractica1
{
    partial class FrmTrabajos
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
            dgvTrabajos = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            butInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTrabajos).BeginInit();
            SuspendLayout();
            // 
            // dgvTrabajos
            // 
            dgvTrabajos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrabajos.Location = new Point(48, 151);
            dgvTrabajos.Name = "dgvTrabajos";
            dgvTrabajos.Size = new Size(436, 361);
            dgvTrabajos.TabIndex = 0;
            dgvTrabajos.CellContentClick += dgvTrabajos_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Location = new Point(48, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 10);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Location = new Point(48, 518);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 10);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Location = new Point(490, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 361);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Location = new Point(32, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 361);
            panel4.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 41);
            label1.Name = "label1";
            label1.Size = new Size(436, 56);
            label1.TabIndex = 5;
            label1.Text = "Tabla de Trabajos";
            // 
            // butInsertar
            // 
            butInsertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            butInsertar.Location = new Point(244, 564);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(75, 23);
            butInsertar.TabIndex = 6;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // FrmTrabajos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(529, 619);
            Controls.Add(butInsertar);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvTrabajos);
            Name = "FrmTrabajos";
            Text = "Tabla de Trabajos";
            Load += FrmTrabajos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTrabajos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTrabajos;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Button butInsertar;
    }
}