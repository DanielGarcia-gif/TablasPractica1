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
    public partial class ActualizarTitulo : Form
    {
        public ActualizarTitulo(string ID, string titulo, string tipo,
                                string pub_ID, string precio, string advance,
                                string royalty, string ytd_sales, string notas, string pubdate)
        {
            InitializeComponent();
            dtpFecha.MaxDate = DateTime.Now;
            txtID.Text = ID;
            txtTitulo.Text = titulo;
            txtTipo.Text = tipo;
            //cbPub_ID.Text = pub_ID;
            txtPrecio.Text = precio;
            txtAdvance.Text = advance;
            txtRoyalty.Text = royalty;
            txtYtd_Sales.Text = ytd_sales;
            dtpFecha.Text = pubdate;
            txtNotas.Text = notas;

            for (int i = 0; i < cmbPubId.Items.Count; i++)
            {
                if (cmbPubId.Items[i].ToString() == pub_ID)
                {
                    cmbPubId.SelectedIndex = i;
                }
            }
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool f = datos.comando("update titles set title = '" + txtTitulo.Text.Replace("'", "''") +
                "', type = '" + txtTipo.Text.Replace("'", "''") + "', pub_id = (select pub_id from publishers where pub_name = '" + cmbPubId.SelectedItem.ToString() + "'), price =" + double.Parse(txtPrecio.Text == "" ? "0" : txtPrecio.Text) + ", advance =" + double.Parse(txtAdvance.Text == "" ? "0" : txtAdvance.Text) +
                ", royalty = " + double.Parse(txtRoyalty.Text == "" ? "0" : txtRoyalty.Text) + ",ytd_sales = " + int.Parse(txtYtd_Sales.Text == "" ? "0" : txtYtd_Sales.Text) +
                ", notes= '" + txtNotas.Text.Replace("'", "''") + "', pubdate='" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day +
                "'  where title_id = '" + txtID.Text + "'");

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

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from titles where title_id = '" + txtID.Text + "'");

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
    }
}
