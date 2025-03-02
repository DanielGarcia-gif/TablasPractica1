namespace TablasPractica1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butTitulos = new Button();
            butEmpleados = new Button();
            SuspendLayout();
            // 
            // butTitulos
            // 
            butTitulos.Location = new Point(26, 23);
            butTitulos.Name = "butTitulos";
            butTitulos.Size = new Size(75, 23);
            butTitulos.TabIndex = 0;
            butTitulos.Text = "Titulos";
            butTitulos.UseVisualStyleBackColor = true;
            butTitulos.Click += butTitulos_Click;
            // 
            // butEmpleados
            // 
            butEmpleados.Location = new Point(182, 23);
            butEmpleados.Name = "butEmpleados";
            butEmpleados.Size = new Size(75, 23);
            butEmpleados.TabIndex = 1;
            butEmpleados.Text = "Empleados";
            butEmpleados.UseVisualStyleBackColor = true;
            butEmpleados.Click += butEmpleados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 69);
            Controls.Add(butEmpleados);
            Controls.Add(butTitulos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button butTitulos;
        private Button butEmpleados;
    }
}
