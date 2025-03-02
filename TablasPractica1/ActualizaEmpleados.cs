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
    public partial class ActualizaEmpleados : Form
    {
        public ActualizaEmpleados(string ID, string fname, string minit,
                                  string lname, string job_ID, string job_lvl,
                                  string pub_ID, string hire_date)
        {
            InitializeComponent();
            txtID.Text = ID;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtMinit.Text = minit;
            txtJob_ID.Text = job_ID;
            txtJob_lvl.Text = job_lvl;
            txtPub_ID.Text = pub_ID;
            mtbHire_Date.Text = hire_date;
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.Show();
        }

        private void ActualizaEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from employee where emp_id = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmEmpleados empleados = new FrmEmpleados();
                    empleados.Show();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = mtbHire_Date.Text.Substring(0, 2);
                string mes = mtbHire_Date.Text.Substring(3, 2);
                string año = mtbHire_Date.Text.Substring(6, 4);
                string fecha = mes + "/" + dia + "/" + año;

                Datos datos = new Datos();
                bool f = datos.comando("update employee set " +
                                       "fname = '" + txtFName.Text.Replace("'", "''") +
                                       "', minit = '" + txtMinit.Text +
                                       "', lname = '" + txtLName.Text.Replace("'", "''") +
                                       "', job_id = " + int.Parse(txtJob_ID.Text) +
                                       ", job_lvl = " + int.Parse(txtJob_lvl.Text) +
                                       ", pub_id = '" + txtPub_ID.Text +
                                       "', hire_date = '" + fecha +
                                       "' where emp_id = '" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    FrmEmpleados empleados = new FrmEmpleados();
                    empleados.Show();
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Alguno de los datos en inconsistente, favor de revisar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if(txtID.Text.Length < 2)
            {
                txtMinit.Text = "";
            }
            else
            {
                string texto = txtID.Text;
                string minit = texto.Substring(1,1);
                txtMinit.Text = minit;
            }
        }
    }
}
