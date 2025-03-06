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
    public partial class ActualizarTrabajo : Form
    {
        public ActualizarTrabajo(string job_ID, string job_desc, string job_minlvl, string job_maxlvl)
        {
            InitializeComponent();
            txtJob_ID.Text = job_ID;
            txtJob_desc.Text = job_desc;
            txtMax.Text = job_maxlvl;
            txtMin.Text = job_minlvl;
        }

        private void ActualizarTrabajo_Load(object sender, EventArgs e)
        {

        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((int.Parse(txtMax.Text) <= 255 || int.Parse(txtMax.Text) >= 0) || (int.Parse(txtMin.Text) <= 255 || int.Parse(txtMin.Text) >= 0))
                {
                    if (int.Parse(txtMax.Text) >= int.Parse(txtMin.Text))
                    {
                        Datos datos = new Datos();
                        bool f = datos.comando("update jobs set " +
                                               "job_desc = " + txtJob_desc.Text +
                                               ", min_lvl = " + txtMin.Text +
                                               ", max_lvl = " + txtMax.Text +
                                               " WHERE job_id = '" + txtJob_ID + "'");

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
                    else
                    {
                        MessageBox.Show("El niver mayor debe ser mayor o igual al nivel menor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Alguno de los niveles no es un valor valido. \nFavor de verificar los rangos (0, 255)", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Tipo de dato no valido. \nFavor de verificar los datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from jobs where job_id = '" + txtJob_ID.Text + "'");

                if (f == true)
                {
                    MessageBox.Show("Datos eliminados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
