using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace GUI
{
    public partial class FrmEstudiante : Form
    {
        BLL_Alumnos negocio;

        public FrmEstudiante()
        {
            negocio = new BLL_Alumnos();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ALUMNO alumno = new ALUMNO();
            BLL_Alumnos negocio = new BLL_Alumnos();
            alumno = negocio.fichaAlumno(Convert.ToInt32(txtUsuario.Text));
            if (alumno.DNI.ToString() == txtUsuario.Text)
            {
                if (alumno.CONTRASENA.ToString() == txtContrasena.Text)
                {
                    if (alumno.ESTADO.ToString() == "true")
                    {
                        this.Hide();
                        FrmMaterias F = new FrmMaterias();
                        F.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Su situacion no le permite inscribirse a examenes, por favor contacte a bedelía");
                    }

                }
                else
                {
                    MessageBox.Show("Su usuario o contraseña no son correctos, por favor contactese con bedelía");
                }

            }
            else
            {
                MessageBox.Show("Su usuario o contraseña no son correctos, por favor contactese con bedelía");
            }
        }

        private void FrmEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin F = new FrmLogin();
            F.ShowDialog();
        }
    }
}
