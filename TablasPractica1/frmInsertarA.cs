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
    public partial class frmInsertarA : Form
    {
        public frmInsertarA()
        {
            InitializeComponent();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("insert into authors values (" + txtID.Text + "," + txtFirstName.Text + "," + txtLastName.Text + "," +
                                   txtPhone.Text + "," + txtAddress.Text + "," + txtCity.Text + "," + txtState.Text + "," +
                                   txtZIP.Text + "," + (chkContract.Checked ? 1 : 0) + ")");
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
