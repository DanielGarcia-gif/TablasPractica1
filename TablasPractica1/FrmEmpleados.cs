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
            DataSet ds = obj.consulta("select emp_id as ID , fname as [Frist Name], minit as Minit, lname as [Last Name], " +
                                      "j.job_desc as [Job Description], job_lvl as [Job Level], pb.pub_name as [PUB Name], " +
                                      "hire_date as [Hire date] from employee e , jobs j, publishers pb " +
                                      "where j.job_id = e.job_id and e.pub_id = pb.pub_id");

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
            DataSet ds = obj.consulta("select emp_id as ID , fname as [Frist Name], minit as Minit, lname as [Last Name], " +
                                      "j.job_desc as [Job Description], job_lvl as [Job Level], pb.pub_name as [PUB Name], " +
                                      "hire_date as [Hire date] from employee e , jobs j, publishers pb " +
                                      "where j.job_id = e.job_id and e.pub_id = pb.pub_id");

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
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            InsertarEmpleados insertar = new InsertarEmpleados();
            insertar.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
