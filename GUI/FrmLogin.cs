using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123456" && txtUserName.Text == "Admin")
            {
                this.Hide();
                FrmPrincipal F = new FrmPrincipal();
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario y contraseña no son correctos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEstudiante F = new FrmEstudiante();
            F.ShowDialog();
        }
    }
}
