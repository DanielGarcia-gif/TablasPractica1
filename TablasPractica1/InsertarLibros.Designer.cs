﻿namespace TablasPractica1
{
    partial class InsertarLibros
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
            mtbPubdate = new MaskedTextBox();
            label10 = new Label();
            label9 = new Label();
            txtAdvance = new TextBox();
            label8 = new Label();
            txtPrecio = new TextBox();
            label7 = new Label();
            txtTipo = new TextBox();
            label6 = new Label();
            txtTitulo = new TextBox();
            label5 = new Label();
            txtNotas = new TextBox();
            label4 = new Label();
            txtYtd_Sales = new TextBox();
            label3 = new Label();
            txtRoyalty = new TextBox();
            label2 = new Label();
            txtPub_ID = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            butInsertar = new Button();
            butCancelar = new Button();
            SuspendLayout();
            // 
            // mtbPubdate
            // 
            mtbPubdate.Location = new Point(142, 143);
            mtbPubdate.Mask = "00/00/0000";
            mtbPubdate.Name = "mtbPubdate";
            mtbPubdate.Size = new Size(100, 23);
            mtbPubdate.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(142, 125);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 41;
            label10.Text = "pubdate";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(269, 68);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 40;
            label9.Text = "Advance";
            // 
            // txtAdvance
            // 
            txtAdvance.Location = new Point(269, 86);
            txtAdvance.Name = "txtAdvance";
            txtAdvance.Size = new Size(149, 23);
            txtAdvance.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(142, 68);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 38;
            label8.Text = "Price";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(142, 86);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(318, 14);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 36;
            label7.Text = "Type";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(318, 32);
            txtTipo.MaxLength = 12;
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(142, 14);
            label6.Name = "label6";
            label6.Size = new Size(29, 15);
            label6.TabIndex = 34;
            label6.Text = "Title";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(142, 32);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(156, 23);
            txtTitulo.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 183);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 32;
            label5.Text = "notes";
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(21, 201);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(400, 23);
            txtNotas.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 125);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 30;
            label4.Text = "ytd_sales";
            // 
            // txtYtd_Sales
            // 
            txtYtd_Sales.Location = new Point(269, 143);
            txtYtd_Sales.Name = "txtYtd_Sales";
            txtYtd_Sales.Size = new Size(100, 23);
            txtYtd_Sales.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 125);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 28;
            label3.Text = "Royalty";
            // 
            // txtRoyalty
            // 
            txtRoyalty.Location = new Point(21, 143);
            txtRoyalty.Name = "txtRoyalty";
            txtRoyalty.Size = new Size(100, 23);
            txtRoyalty.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 68);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 26;
            label2.Text = "pub_ID";
            // 
            // txtPub_ID
            // 
            txtPub_ID.Location = new Point(21, 86);
            txtPub_ID.MaxLength = 4;
            txtPub_ID.Name = "txtPub_ID";
            txtPub_ID.Size = new Size(100, 23);
            txtPub_ID.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 14);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 24;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Location = new Point(21, 32);
            txtID.MaxLength = 8;
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 23;
            // 
            // butInsertar
            // 
            butInsertar.Location = new Point(265, 249);
            butInsertar.Name = "butInsertar";
            butInsertar.Size = new Size(75, 23);
            butInsertar.TabIndex = 43;
            butInsertar.Text = "Insertar";
            butInsertar.UseVisualStyleBackColor = true;
            butInsertar.Click += butInsertar_Click;
            // 
            // butCancelar
            // 
            butCancelar.Location = new Point(346, 249);
            butCancelar.Name = "butCancelar";
            butCancelar.Size = new Size(75, 23);
            butCancelar.TabIndex = 44;
            butCancelar.Text = "Cancelar";
            butCancelar.UseVisualStyleBackColor = true;
            butCancelar.Click += butCancelar_Click;
            // 
            // InsertarLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 284);
            Controls.Add(butCancelar);
            Controls.Add(butInsertar);
            Controls.Add(mtbPubdate);
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
            Name = "InsertarLibros";
            Text = "InsertarLibros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtbPubdate;
        private Label label10;
        private Label label9;
        private TextBox txtAdvance;
        private Label label8;
        private TextBox txtPrecio;
        private Label label7;
        private TextBox txtTipo;
        private Label label6;
        private TextBox txtTitulo;
        private Label label5;
        private TextBox txtNotas;
        private Label label4;
        private TextBox txtYtd_Sales;
        private Label label3;
        private TextBox txtRoyalty;
        private Label label2;
        private TextBox txtPub_ID;
        private Label label1;
        private TextBox txtID;
        private Button butInsertar;
        private Button butCancelar;
    }
}