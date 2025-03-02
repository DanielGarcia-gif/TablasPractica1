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
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(0, 0);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(800, 416);
            dgvEmpleados.TabIndex = 0;
            dgvEmpleados.CellContentClick += dgvEmpleados_CellContentClick;
            // 
            // butInsertar
            // 
            butInsertar.Location = new Point(713, 422);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(75, 23);
            butInsertar.TabIndex = 1;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butInsertar);
            Controls.Add(dgvEmpleados);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Activated += FrmEmpleados_Activated;
            Load += FrmEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button butInsertar;
    }
}