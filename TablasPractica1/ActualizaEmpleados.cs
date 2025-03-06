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
            dtpFecha.MaxDate = DateTime.Now;
            txtID.Text = ID;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtMinit.Text = minit;
            //cbJob_ID.SelectedIndex = int.Parse(job_ID) - 1;
            txtJob_lvl.Text = job_lvl;
            //cbPub_ID.Text = pub_ID;
            dtpFecha.Text = hire_date;

            for (int i = 0; i < cbJob_ID.Items.Count; i++)
            {
                if (cbJob_ID.Items[i].ToString() == job_ID)
                {
                    cbJob_ID.SelectedIndex = i;
                }

            }

            for (int i = 0; i < cmbPubId.Items.Count; i++)
            {
                if (cmbPubId.Items[i].ToString() == pub_ID)
                {
                    cmbPubId.SelectedIndex = i;
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualizaEmpleados_Load(object sender, EventArgs e)
        {
            if (txtID.Text.Substring(8, 1) == "M")
            {
                pictureBox.Image = Image.FromFile("C:\\Users\\yadia\\OneDrive\\Escritorio\\4to SEMESTRE\\TOPICOS AVANZADOS DE PROGRAMACION\\" +
                                                  "TEMA 1\\EXAMEN\\UNIDAD 2\\PRACTICAS\\TEMA 2\\TablasPractica1\\TablasPractica1\\bin\\" +
                                                  "Debug\\net8.0-windows\\employeeM.png");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (txtID.Text.Substring(8, 1) == "F")
            {
                pictureBox.Image = Image.FromFile("C:\\Users\\yadia\\OneDrive\\Escritorio\\4to SEMESTRE\\TOPICOS AVANZADOS DE PROGRAMACION\\" +
                                                  "TEMA 1\\EXAMEN\\UNIDAD 2\\PRACTICAS\\TEMA 2\\TablasPractica1\\TablasPractica1\\bin\\" +
                                                  "Debug\\net8.0-windows\\employee.jpg");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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
                Datos datos = new Datos();
                bool f = datos.comando("update employee set fname = '" + txtFName.Text.Replace("'", "''") + "'," +
                    "minit ='" + txtMinit.Text + "',lname ='" + txtLName.Text.Replace("'", "''") + "',job_id= '" + (cbJob_ID.SelectedIndex + 1) +
                    "', job_lvL ='" + txtJob_lvl.Text + "',pub_id = (select pub_id from publishers where pub_name = '" + cmbPubId.SelectedItem.ToString() + "'), hire_date= '"
                    + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "' where emp_id = " +
                    "'" + txtID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
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
