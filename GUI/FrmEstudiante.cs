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
        NEGOCIO negocio;

        public FrmEstudiante()
        {
            negocio = new NEGOCIO();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ALUMNO alumno = new ALUMNO();
            NEGOCIO negocio = new NEGOCIO();
            alumno = negocio.fichaAlumno(Convert.ToInt32(txtUsuario.Text));
            if (alumno.DNI.ToString() == txtUsuario.Text)
            {
                if (alumno.CONTRASENA.ToString() == txtContrasena.Text)
                {
                    this.Hide();
                    Examenes F = new Examenes();
                    F.ShowDialog();
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
    }
}
