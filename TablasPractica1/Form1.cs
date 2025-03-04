namespace TablasPractica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butTitulos_Click(object sender, EventArgs e)
        {
            FrmTitulos titulos = new FrmTitulos();
            titulos.Show();
        }

        private void butEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados Empleados = new FrmEmpleados();
            Empleados.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
