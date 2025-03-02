namespace TablasPractica1
{
    partial class ActualizaEmpleados
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
            butEliminar = new Button();
            mtbHire_Date = new MaskedTextBox();
            butActualizar = new Button();
            butCancelar = new Button();
            label10 = new Label();
            label9 = new Label();
            txtJob_lvl = new TextBox();
            label8 = new Label();
            txtJob_ID = new TextBox();
            label7 = new Label();
            txtLName = new TextBox();
            label6 = new Label();
            txtFName = new TextBox();
            label3 = new Label();
            txtPub_ID = new TextBox();
            label2 = new Label();
            txtMinit = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(230, 186);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(75, 23);
            butEliminar.TabIndex = 46;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // mtbHire_Date
            // 
            mtbHire_Date.Location = new Point(133, 139);
            mtbHire_Date.Mask = "00/00/0000";
            mtbHire_Date.Name = "mtbHire_Date";
            mtbHire_Date.Size = new Size(100, 23);
            mtbHire_Date.TabIndex = 45;
            // 
            // butActualizar
            // 
            butActualizar.Location = new Point(311, 186);
            butActualizar.Name = "butActualizar";
            butActualizar.Size = new Size(75, 23);
            butActualizar.TabIndex = 44;
            butActualizar.Text = "Actualizar";
            butActualizar.UseVisualStyleBackColor = true;
            butActualizar.Click += butActualizar_Click;
            // 
            // butCancelar
            // 
            butCancelar.Location = new Point(393, 186);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(75, 23);
            butCancelar.TabIndex = 43;
            butCancelar.Text = "Cancelar";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(133, 121);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 42;
            label10.Text = "Hire_date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(133, 65);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 41;
            label9.Text = "Job_lvl";
            // 
            // txtJob_lvl
            // 
            txtJob_lvl.Location = new Point(133, 83);
            txtJob_lvl.Name = "txtJob_lvl";
            txtJob_lvl.Size = new Size(121, 23);
            txtJob_lvl.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 65);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 39;
            label8.Text = "Job_ID";
            // 
            // txtJob_ID
            // 
            txtJob_ID.Location = new Point(12, 83);
            txtJob_ID.Name = "txtJob_ID";
            txtJob_ID.Size = new Size(100, 23);
            txtJob_ID.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(275, 10);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 37;
            label7.Text = "LName";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(275, 28);
            txtLName.MaxLength = 12;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(134, 23);
            txtLName.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 10);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 35;
            label6.Text = "FName";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(133, 28);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(121, 23);
            txtFName.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 29;
            label3.Text = "Pub_ID";
            // 
            // txtPub_ID
            // 
            txtPub_ID.Location = new Point(12, 139);
            txtPub_ID.MaxLength = 4;
            txtPub_ID.Name = "txtPub_ID";
            txtPub_ID.Size = new Size(100, 23);
            txtPub_ID.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(428, 10);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 27;
            label2.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(428, 28);
            txtMinit.MaxLength = 1;
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(30, 23);
            txtMinit.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 28);
            txtID.MaxLength = 9;
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 24;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // ActualizaEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 223);
            Controls.Add(butEliminar);
            Controls.Add(mtbHire_Date);
            Controls.Add(butActualizar);
            Controls.Add(butCancelar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtJob_lvl);
            Controls.Add(label8);
            Controls.Add(txtJob_ID);
            Controls.Add(label7);
            Controls.Add(txtLName);
            Controls.Add(label6);
            Controls.Add(txtFName);
            Controls.Add(label3);
            Controls.Add(txtPub_ID);
            Controls.Add(label2);
            Controls.Add(txtMinit);
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "ActualizaEmpleados";
            Text = "ActualizaEmpleados";
            Load += ActualizaEmpleados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butEliminar;
        private MaskedTextBox mtbHire_Date;
        private Button butActualizar;
        private Button butCancelar;
        private Label label10;
        private Label label9;
        private TextBox txtJob_lvl;
        private Label label8;
        private TextBox txtJob_ID;
        private Label label7;
        private TextBox txtLName;
        private Label label6;
        private TextBox txtFName;
        private Label label3;
        private TextBox txtPub_ID;
        private Label label2;
        private TextBox txtMinit;
        private Label label1;
        private TextBox txtID;
    }
}