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
    public partial class InsertarEmpleados : Form
    {
        public InsertarEmpleados()
        {
            InitializeComponent();
            dtpFecha.MaxDate = DateTime.Now;
            pictureBox.Image = null;
        }

        private void butCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Substring(8, 1) != "M" && txtID.Text.Substring(8, 1) != "F")
                {
                    MessageBox.Show("Error al insertar \nEl ultimo digito del ID es el genero \n- Masculino (M) \n- Femenino (F)",
                                    "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox.Image = null;
                }
                else
                {
                    Datos datos = new Datos();
                    bool f = datos.comando("insert into employee values ('" + txtID.Text + "'" +
                                           ",'" + txtFName.Text.Replace("'", "''") + "','" + txtMinit.Text + "','" 
                                           + txtLName.Text.Replace("'", "''") + "', (select job_id from jobs where job_desc ='" 
                                           + cbJob_ID.SelectedItem.ToString() + "' )" + ",'" + txtJob_lvl.Text 
                                           + "',(select pub_id from publishers where pub_name = '" + cmbPubId.SelectedItem.ToString() 
                                           + "'),'" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day + "')");

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
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error al insertar. Favor de verificar los tipos de datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Error al insertar. Favor de verificar los tipos de datos ingresados", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Length < 2)
            {
                txtMinit.Text = "";
            }
            else
            {
                string texto = txtID.Text;
                string minit = texto.Substring(1, 1);
                txtMinit.Text = minit;
            }

            if (txtID.Text.Length > 8)
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
                else
                {
                    pictureBox.Image = null;
                }
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        private void InsertarEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}
