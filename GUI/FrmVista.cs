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
    public partial class FrmVista : Form
    {

        public string Tabla;
        public FrmVista()
        {
            InitializeComponent();
        }

        private void FrmVista_Load(object sender, EventArgs e)
        {

            NEGOCIO N = new NEGOCIO();
            N.MostrarTabla(dataGridView1, Tabla);


        }
    }
}
