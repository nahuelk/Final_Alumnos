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
using System.IO;
using System.Collections;

namespace GUI
{
    public partial class FrmMaterias : Form
    {
        public FrmMaterias()
        {
            
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array al = new Array[100];
            BLL_Materias negocio = new BLL_Materias();
            //al = negocio.ListadoMaterias(Convert.ToInt32(comboBox2.SelectedItem.ToString()));



        }

        private void Examenes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet3.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter1.Fill(this.finalDataSet3.MATERIAS);
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet2.EXAMEN' Puede moverla o quitarla según sea necesario.
            //this.eXAMENTableAdapter.Fill(this.finalDataSet2.EXAMEN);
            // TODO: esta línea de código carga datos en la tabla 'finalDataSet1.MATERIAS' Puede moverla o quitarla según sea necesario.
            this.mATERIASTableAdapter.Fill(this.finalDataSet1.MATERIAS);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin F = new FrmLogin();
            F.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
