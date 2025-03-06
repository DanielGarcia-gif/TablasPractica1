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
    public partial class InsertarTrabajo : Form
    {
        public InsertarTrabajo()
        {
            InitializeComponent();
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            if ((int.Parse(txtMax.Text) <= 255 || int.Parse(txtMax.Text) >= 0) || (int.Parse(txtMin.Text) <= 255 || int.Parse(txtMin.Text) >= 0))
            {
                if (int.Parse(txtMax.Text) >= int.Parse(txtMin.Text))
                {
                    Datos datos = new Datos();
                    bool f = datos.comando("insert into jobs values (" +
                                            txtJob_ID.Text + ","
                                           + txtJob_desc.Text + ","
                                           + txtMin.Text + ","
                                           + txtMax.Text + ")");

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
    }
}
