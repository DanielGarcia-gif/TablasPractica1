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
    public partial class FrmAutores : Form
    {
        public FrmAutores()
        {
            InitializeComponent();
        }

        private void FrmAutores_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select * From authors");

            if (ds != null)
            {
                dgvAutors.DataSource = ds.Tables[0];
            }
        }

        private void actualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select au_id as ID,au_lname as [Last Name],au_fname as [Firts Name],phone as Phone,authors.address as Address,city as City,state as State,zip as Zip,contract as Contract From authors");

            if (ds != null)
            {
                dgvAutors.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertarA inse = new frmInsertarA();
            inse.Show();
        }

        private void dgvAutors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizaAutor actualiza = new ActualizaAutor(dgvAutors[0, e.RowIndex].Value.ToString(), dgvAutors[1, e.RowIndex].Value.ToString(),
                                              dgvAutors[2, e.RowIndex].Value.ToString(), dgvAutors[3, e.RowIndex].Value.ToString(),
                                              dgvAutors[4, e.RowIndex].Value.ToString(), dgvAutors[5, e.RowIndex].Value.ToString(),
                                              dgvAutors[6, e.RowIndex].Value.ToString(), dgvAutors[7, e.RowIndex].Value.ToString(),
                                              Convert.ToBoolean(dgvAutors[8, e.RowIndex].Value));
            actualiza.Show();
        }

        private void FrmAutores_Activated(object sender, EventArgs e)
        {
            actualizaGrid();
        }
    }
}
