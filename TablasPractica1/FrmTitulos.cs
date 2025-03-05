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
    public partial class FrmTitulos : Form
    {
        public FrmTitulos()
        {
            InitializeComponent();
        }

        private void FrmTitulos_Load(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta(("Select title_id as ID,title as [Title], type as [Type],pub_id as PubID," +
                                      "price as Price,advance as Advance ,royalty as Royalty,ytd_sales as Sales," +
                                      "notes as Notes,pubdate as PubDate From Titles");

            if (ds != null)
            {
                dgvTitulos.DataSource = ds.Tables[0];
            }
        }

        private void dgvTitulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ActualizarTitulo actualiza = new ActualizarTitulo(dgvTitulos[0, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[1, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[2, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[3, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[4, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[5, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[6, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[7, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[8, e.RowIndex].Value.ToString(),
                                                              dgvTitulos[9, e.RowIndex].Value.ToString());

            actualiza.Show();
            this.Close();
        }

        private void FrmTitulos_Activated(object sender, EventArgs e)
        {
            ActualizaGrid();
        }

        private void ActualizaGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("Select title_id as ID,title as [Title], type as [Type],pub_id as PubID," +
                                      "price as Price,advance as Advance ,royalty as Royalty,ytd_sales as Sales," +
                                      "notes as Notes,pubdate as PubDate From Titles");

            if (ds != null)
            {
                dgvTitulos.DataSource = ds.Tables[0];
            }
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            InsertarLibros libros = new InsertarLibros();
            libros.Show();
            this.Close();
        }
    }
}
