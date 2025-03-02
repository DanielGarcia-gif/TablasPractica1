namespace TablasPractica1
{
    partial class InsertarEmpleados
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
            mtbHire_Date = new MaskedTextBox();
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
            butInsertar = new Button();
            butCancelar = new Button();
            SuspendLayout();
            // 
            // mtbHire_Date
            // 
            mtbHire_Date.Location = new Point(142, 146);
            mtbHire_Date.Mask = "00/00/0000";
            mtbHire_Date.Name = "mtbHire_Date";
            mtbHire_Date.Size = new Size(100, 23);
            mtbHire_Date.TabIndex = 61;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(142, 128);
            label10.Name = "label10";
            label10.Size = new Size(57, 15);
            label10.TabIndex = 60;
            label10.Text = "Hire_date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(142, 72);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 59;
            label9.Text = "Job_lvl";
            // 
            // txtJob_lvl
            // 
            txtJob_lvl.Location = new Point(142, 90);
            txtJob_lvl.Name = "txtJob_lvl";
            txtJob_lvl.Size = new Size(121, 23);
            txtJob_lvl.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 72);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 57;
            label8.Text = "Job_ID";
            // 
            // txtJob_ID
            // 
            txtJob_ID.Location = new Point(21, 90);
            txtJob_ID.Name = "txtJob_ID";
            txtJob_ID.Size = new Size(100, 23);
            txtJob_ID.TabIndex = 56;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 17);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 55;
            label7.Text = "LName";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(284, 35);
            txtLName.MaxLength = 12;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(134, 23);
            txtLName.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 17);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 53;
            label6.Text = "FName";
            // 
            // txtFName
            // 
            txtFName.Location = new Point(142, 35);
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(121, 23);
            txtFName.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 128);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 51;
            label3.Text = "Pub_ID";
            // 
            // txtPub_ID
            // 
            txtPub_ID.Location = new Point(21, 146);
            txtPub_ID.MaxLength = 4;
            txtPub_ID.Name = "txtPub_ID";
            txtPub_ID.Size = new Size(100, 23);
            txtPub_ID.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(437, 17);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 49;
            label2.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.Location = new Point(437, 35);
            txtMinit.MaxLength = 1;
            txtMinit.Name = "txtMinit";
            txtMinit.Size = new Size(30, 23);
            txtMinit.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 47;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(21, 35);
            txtID.MaxLength = 9;
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 46;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // butInsertar
            // 
            butInsertar.Location = new Point(311, 190);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(75, 23);
            butInsertar.TabIndex = 62;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // butCancelar
            // 
            butCancelar.Location = new Point(392, 190);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(75, 23);
            butCancelar.TabIndex = 63;
            butCancelar.Text = "Cancelar";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // InsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 225);
            Controls.Add(butCancelar);
            Controls.Add(butInsertar);
            Controls.Add(mtbHire_Date);
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
            Name = "InsertarEmpleados";
            Text = "InsertarEmpleados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbHire_Date;
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
        private Button butInsertar;
        private Button butCancelar;
    }
}