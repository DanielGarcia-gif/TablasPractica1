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
    public partial class InsertarLibros : Form
    {
        public InsertarLibros()
        {
            InitializeComponent();
            dtpFecha.MaxDate = DateTime.Now;
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool f = datos.comando("insert into titles values('" +
                "" + txtID.Text.Replace("'", "''") + "', '" + txtTitulo.Text.Replace("'", "''") + "', '" + txtTipo.Text.Replace("'", "''") + 
                "', (select pub_id from publishers where pub_name ='" +
                "" + cmbPubId.SelectedItem.ToString() + "')," + double.Parse(txtPrecio.Text) + "," + double.Parse(txtAdvance.Text) +
                "," + double.Parse(txtRoyalty.Text) + "," + int.Parse(txtYtd_Sales.Text) + ",'" + txtNotas.Text.Replace("'", "''") + "'" +
                ", '" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "-" + dtpFecha.Value.Year + "')");

                if (f == true)
                {
                    MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error al insertar. Favor de verificar los tipos de datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Error al insertar. Favor de verificar los datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
