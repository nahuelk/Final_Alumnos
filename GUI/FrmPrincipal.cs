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


namespace GUI
{
    public partial class FrmPrincipal : Form
    {
     
        public FrmPrincipal()
        {
          
            InitializeComponent();
        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlumno F = new FrmAlumno();
            F.MdiParent = this;
            F.Show();
        }

        private void vISTASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVista F = new FrmVista();
            F.MdiParent = this;
            F.Tabla = "ALUMNOS";
            F.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos Xml|*.xml";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            NEGOCIO negocio = new NEGOCIO();

            negocio.ExportarXml(saveFileDialog1.FileName, "ALUMNOS");

        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Archivos CSV|*.csv";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            NEGOCIO negocio = new NEGOCIO();

            negocio.ExportarCsv(saveFileDialog1.FileName, "ALUMNOS");
        }

        private void cSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo (txt,csv)|*.txt;*.csv";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;

            NEGOCIO negocio = new NEGOCIO();

            negocio.ImportarArchivo(archivo);
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo (XML)|*.xml";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            string archivo = openFileDialog1.FileName;

            NEGOCIO negocio = new NEGOCIO();

            negocio.ImportardesdeXML(archivo);
        }
    }
}
