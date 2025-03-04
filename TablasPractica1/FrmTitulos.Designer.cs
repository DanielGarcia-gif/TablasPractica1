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
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).BeginInit();
            SuspendLayout();
            // 
            // dgvTitulos
            // 
            dgvTitulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTitulos.Location = new Point(0, 0);
            dgvTitulos.Name = "dgvTitulos";
            dgvTitulos.Size = new Size(1086, 413);
            dgvTitulos.TabIndex = 0;
            dgvTitulos.CellContentClick += dgvTitulos_CellContentClick;
            // 
            // butInsertar
            // 
            butInsertar.BackgroundImage = Properties.Resources.pngwing_com__6_;
            butInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            butInsertar.Location = new Point(457, 428);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(171, 119);
            butInsertar.TabIndex = 1;
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // FrmTitulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 559);
            Controls.Add(butInsertar);
            Controls.Add(dgvTitulos);
            Name = "FrmTitulos";
            Text = "FrmTitulos";
            Activated += FrmTitulos_Activated;
            Load += FrmTitulos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTitulos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTitulos;
        private Button butInsertar;
    }
}