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
    public partial class FrmTrabajos : Form
    {
        public FrmTrabajos()
        {
            InitializeComponent();
        }

        private void FrmTrabajos_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * From jobs");

            if (ds != null)
            {
                dgvTrabajos.DataSource = ds.Tables[0];
            }
        }

        private void actualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select job_id as ID, job_desc as [Job Desc], min_lvl as [Nivel Minimo], max_lvl as [Nivel Maximo] From jobs");

            if (ds != null)
            {
                dgvTrabajos.DataSource = ds.Tables[0];
            }
        }

        private void dgvTrabajos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarTrabajo actualiza = new ActualizarTrabajo(dgvTrabajos[0, e.RowIndex].Value.ToString(),
                                                                dgvTrabajos[1, e.RowIndex].Value.ToString(),
                                                                dgvTrabajos[2, e.RowIndex].Value.ToString(),
                                                                dgvTrabajos[3, e.RowIndex].Value.ToString());
            actualiza.Show();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            InsertarTrabajo trabajo = new InsertarTrabajo();
            trabajo.Show();
        }
    }
}
