using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TablasPractica1
{
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * From employee");

            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
        }

        private void FrmEmpleados_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }
        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * For employee");

            if (ds != null)
            {
                dgvEmpleados.DataSource = ds.Tables[0];
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizaEmpleados actualiza = new ActualizaEmpleados(dgvEmpleados[0, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[1, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[2, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[3, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[4, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[5, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[6, e.RowIndex].Value.ToString(),
                                                                  dgvEmpleados[7, e.RowIndex].Value.ToString());

            actualiza.Show();
            this.Close();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            InsertarEmpleados insertar = new InsertarEmpleados();
            insertar.Show();
            this.Close();
        }
    }
}
