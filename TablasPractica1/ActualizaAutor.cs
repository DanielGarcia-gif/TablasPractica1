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
    public partial class ActualizaAutor : Form
    {
        public ActualizaAutor(string id, string fname, string lname,
                              string phone, string address, string city,
                              string state, string zip, bool contract)
        {
            InitializeComponent();
            txtFirstName.Text = fname;
            txtLastName.Text = lname;
            txtPhone.Text = phone;
            txtAddress.Text = address;
            txtCity.Text = city;
            txtState.Text = state;
            txtZIP.Text = zip;
            txtID.Text = id;
            chkContract.Checked = contract;
        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("update authors set " +
                                   "au_fname = '" + txtFirstName.Text +
                                   "', au_lname = '" + txtLastName.Text +
                                   "', phone = '" + txtPhone.Text +
                                   "', address = '" + txtAddress.Text +
                                   "', city = '" + txtCity.Text +
                                   "', state = '" + txtState.Text +
                                   "', zip = '" + txtZIP.Text +
                                   "', contract = " + (chkContract.Checked ? 1 : 0) +
                                   " where au_id = '" + txtID.Text + "'");

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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Esta seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from authors where au_id = '" + txtID.Text + "'");

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
