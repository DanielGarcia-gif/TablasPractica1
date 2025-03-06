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
            label10 = new Label();
            label9 = new Label();
            txtJob_lvl = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtLName = new TextBox();
            label6 = new Label();
            txtFName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtMinit = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            butInsertar = new Button();
            butCancelar = new Button();
            pictureBox = new PictureBox();
            cbJob_ID = new ComboBox();
            cmbPubId = new ComboBox();
            dtpFecha = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.Location = new Point(20, 128);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 60;
            label10.Text = "Hire_date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(229, 72);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 59;
            label9.Text = "Job_lvl";
            // 
            // txtJob_lvl
            // 
            txtJob_lvl.BackColor = Color.FromArgb(224, 224, 224);
            txtJob_lvl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtJob_lvl.Location = new Point(229, 90);
            txtJob_lvl.Name = "txtJob_lvl";
            txtJob_lvl.Size = new Size(121, 23);
            txtJob_lvl.TabIndex = 58;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.Location = new Point(21, 72);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 57;
            label8.Text = "Job_ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(284, 17);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 55;
            label7.Text = "LName";
            // 
            // txtLName
            // 
            txtLName.BackColor = Color.FromArgb(224, 224, 224);
            txtLName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtLName.Location = new Point(284, 35);
            txtLName.MaxLength = 30;
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(134, 23);
            txtLName.TabIndex = 54;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(142, 17);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 53;
            label6.Text = "FName";
            // 
            // txtFName
            // 
            txtFName.BackColor = Color.FromArgb(224, 224, 224);
            txtFName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtFName.Location = new Point(142, 35);
            txtFName.MaxLength = 20;
            txtFName.Name = "txtFName";
            txtFName.Size = new Size(121, 23);
            txtFName.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(20, 179);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 51;
            label3.Text = "Pub_ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(437, 17);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 49;
            label2.Text = "Minit";
            // 
            // txtMinit
            // 
            txtMinit.BackColor = Color.Silver;
            txtMinit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtMinit.Location = new Point(437, 35);
            txtMinit.MaxLength = 1;
            txtMinit.Name = "txtMinit";
            txtMinit.ReadOnly = true;
            txtMinit.Size = new Size(30, 23);
            txtMinit.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 17);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 47;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(224, 224, 224);
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            txtID.Location = new Point(21, 35);
            txtID.MaxLength = 9;
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 46;
            txtID.TextChanged += txtID_TextChanged;
            // 
            // butInsertar
            // 
            butInsertar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_192348;
            butInsertar.BackgroundImageLayout = ImageLayout.Stretch;
            butInsertar.Location = new Point(239, 190);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(111, 34);
            butInsertar.TabIndex = 62;
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // butCancelar
            // 
            butCancelar.BackgroundImage = Properties.Resources.Captura_de_pantalla_2025_03_03_182401;
            butCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            butCancelar.Location = new Point(356, 190);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(111, 34);
            butCancelar.TabIndex = 63;
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.employeeM;
            pictureBox.Location = new Point(374, 72);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(93, 97);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 64;
            pictureBox.TabStop = false;
            // 
            // cbJob_ID
            // 
            cbJob_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJob_ID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbJob_ID.FormattingEnabled = true;
            cbJob_ID.Items.AddRange(new object[] { "New Hire - Job not specified", "Chief Executive Officer", "Business Operations Manager", "Chief Financial Officier", "Publisher", "Managing Editor", "Marketing Manager", "Public Relations Manager", "Acquisitions Manager", "Productions Manager", "Operations Manager", "Editor", "Sales Representative", "Designer" });
            cbJob_ID.Location = new Point(22, 90);
            cbJob_ID.Name = "cbJob_ID";
            cbJob_ID.Size = new Size(181, 23);
            cbJob_ID.TabIndex = 65;
            // 
            // cmbPubId
            // 
            cmbPubId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPubId.FormattingEnabled = true;
            cmbPubId.Items.AddRange(new object[] { "New Moon Books", "Binnet & Hardley", "Algodata Infosystems", "Five Lakes Publishing", "Ramona Publishers", "GGG&G", "Scootney Books", "Lucerne Publishing" });
            cmbPubId.Location = new Point(21, 197);
            cmbPubId.Margin = new Padding(3, 2, 3, 2);
            cmbPubId.Name = "cmbPubId";
            cmbPubId.Size = new Size(181, 23);
            cmbPubId.TabIndex = 66;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(20, 146);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(243, 23);
            dtpFecha.TabIndex = 67;
            // 
            // InsertarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(483, 242);
            Controls.Add(dtpFecha);
            Controls.Add(cmbPubId);
            Controls.Add(cbJob_ID);
            Controls.Add(pictureBox);
            Controls.Add(butCancelar);
            Controls.Add(butInsertar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtJob_lvl);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtLName);
            Controls.Add(label6);
            Controls.Add(txtFName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtMinit);
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "InsertarEmpleados";
            Text = "Insertar Nuevo Empleado";
            Load += InsertarEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label10;
        private Label label9;
        private TextBox txtJob_lvl;
        private Label label8;
        private Label label7;
        private TextBox txtLName;
        private Label label6;
        private TextBox txtFName;
        private Label label3;
        private Label label2;
        private TextBox txtMinit;
        private Label label1;
        private TextBox txtID;
        private Button butInsertar;
        private Button butCancelar;
        private PictureBox pictureBox;
        private ComboBox cbJob_ID;
        private ComboBox cmbPubId;
        private DateTimePicker dtpFecha;
    }
}