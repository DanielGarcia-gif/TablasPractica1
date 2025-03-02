namespace TablasPractica1
{
    partial class ActualizarTitulo
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
            txtID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPub_ID = new TextBox();
            label3 = new Label();
            txtRoyalty = new TextBox();
            label4 = new Label();
            txtYtd_Sales = new TextBox();
            label5 = new Label();
            txtNotas = new TextBox();
            label6 = new Label();
            txtTitulo = new TextBox();
            label7 = new Label();
            txtTipo = new TextBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            label9 = new Label();
            txtAdvance = new TextBox();
            label10 = new Label();
            butCancelar = new Button();
            txtActualizar = new Button();
            mtbPubdate = new MaskedTextBox();
            butEliminar = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(15, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 68);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "pub_ID";
            // 
            // txtPub_ID
            // 
            txtPub_ID.Location = new Point(15, 86);
            txtPub_ID.MaxLength = 4;
            txtPub_ID.Name = "txtPub_ID";
            txtPub_ID.Size = new Size(100, 23);
            txtPub_ID.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 125);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Royalty";
            // 
            // txtRoyalty
            // 
            txtRoyalty.Location = new Point(15, 143);
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(100, 23);
            txtRoyalty.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 125);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "ytd_sales";
            // 
            // txtYtd_Sales
            // 
            txtYtd_Sales.Location = new Point(263, 143);
            txtYtd_Sales.Name = "txtYtd_Sales";
            txtYtd_Sales.Size = new Size(100, 23);
            txtYtd_Sales.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 183);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 9;
            label5.Text = "notes";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(20, 201);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(392, 23);
            txtNotas.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 14);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 11;
            label6.Text = "Title";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(136, 32);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(156, 23);
            txtTitulo.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 14);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 13;
            label7.Text = "Type";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(312, 32);
            txtTipo.MaxLength = 12;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 12;
            txtTipo.TextChanged += txtTipo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(136, 68);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 15;
            label8.Text = "Price";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(136, 86);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(263, 68);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 17;
            label9.Text = "Advance";
            // 
            // txtAdvance
            // 
            txtAdvance.Location = new Point(263, 86);
            txtAdvance.Name = "txtAdvance";
            txtAdvance.Size = new Size(149, 23);
            txtAdvance.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(136, 125);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 19;
            label10.Text = "pubdate";
            // 
            // butCancelar
            // 
            butCancelar.Location = new Point(345, 247);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(75, 23);
            butCancelar.TabIndex = 20;
            butCancelar.Text = "Cancelar";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // txtActualizar
            // 
            txtActualizar.Location = new Point(263, 247);
            txtActualizar.Name = "txtActualizar";
            txtActualizar.Size = new Size(75, 23);
            txtActualizar.TabIndex = 21;
            txtActualizar.Text = "Actualizar";
            txtActualizar.UseVisualStyleBackColor = true;
            txtActualizar.Click += txtActualizar_Click;
            // 
            // mtbPubdate
            // 
            mtbPubdate.Location = new Point(136, 143);
            mtbPubdate.Mask = "00/00/0000";
            mtbPubdate.Name = "mtbPubdate";
            mtbPubdate.Size = new Size(100, 23);
            mtbPubdate.TabIndex = 22;
            // 
            // butEliminar
            // 
            butEliminar.Location = new Point(182, 247);
            butEliminar.Name = "butEliminar";
            butEliminar.Size = new Size(75, 23);
            butEliminar.TabIndex = 23;
            butEliminar.Text = "Eliminar";
            butEliminar.UseVisualStyleBackColor = true;
            butEliminar.Click += butEliminar_Click;
            // 
            // ActualizarTitulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 282);
            Controls.Add(butEliminar);
            Controls.Add(mtbPubdate);
            Controls.Add(txtActualizar);
            Controls.Add(butCancelar);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtAdvance);
            Controls.Add(label8);
            Controls.Add(txtPrecio);
            Controls.Add(label7);
            Controls.Add(txtTipo);
            Controls.Add(label6);
            Controls.Add(txtTitulo);
            Controls.Add(label5);
            Controls.Add(txtNotas);
            Controls.Add(label4);
            Controls.Add(txtYtd_Sales);
            Controls.Add(label3);
            Controls.Add(txtRoyalty);
            Controls.Add(label2);
            Controls.Add(txtPub_ID);
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "ActualizarTitulo";
            Text = "ActualizarTitulo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label label1;
        private Label label2;
        private TextBox txtPub_ID;
        private Label label3;
        private TextBox txtRoyalty;
        private Label label4;
        private TextBox txtYtd_Sales;
        private Label label5;
        private TextBox txtNotas;
        private Label label6;
        private TextBox txtTitulo;
        private Label label7;
        private TextBox txtTipo;
        private Label label8;
        private TextBox txtPrecio;
        private Label label9;
        private TextBox txtAdvance;
        private Label label10;
        private Button butCancelar;
        private Button txtActualizar;
        private MaskedTextBox mtbPubdate;
        private Button butEliminar;
    }
}