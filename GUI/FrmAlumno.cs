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
    public partial class FrmAlumno : Form
    {
        BLL_Alumnos negocio;
        public FrmAlumno()
        {
            negocio = new BLL_Alumnos();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ALUMNO E = new ALUMNO();
            E.DNI = Convert.ToInt32(txtDni.Text);
            E.APELLIDO = txtApellido.Text;
            E.NOMBRE = txtNombre.Text;
            E.MATRICULA = Convert.ToInt32(txtMatricula.Text);
            E.CONTRASENA = txtContrasena.Text;

            if (chkbxHabilitado.Checked)
            {
                E.ESTADO = "true";
            }
            else
            {
                E.ESTADO = "false";
            }
            negocio.AltaAlumno(E);

            MessageBox.Show("El registro ha sido dado de alta");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            ALUMNO E = new ALUMNO();
            E.DNI = Convert.ToInt32(txtDni.Text);
            E.APELLIDO = txtApellido.Text;
            E.NOMBRE = txtNombre.Text;
            E.MATRICULA = Convert.ToInt32(txtMatricula.Text);
            E.CONTRASENA = txtContrasena.Text;
            if (chkbxHabilitado.Checked)
            {
                E.ESTADO = "true";
            }
            else
            {
                E.ESTADO = "false";
            }
            negocio.ModificarAlumno(E);

            MessageBox.Show("El registro ha sido modificado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ALUMNO alumno = new ALUMNO();
            BLL_Alumnos negocio = new BLL_Alumnos();
            alumno = negocio.fichaAlumno(Convert.ToInt32(txtDni.Text));
            if (alumno.DNI != 0)
            {
                txtApellido.Text = alumno.APELLIDO;
                txtNombre.Text = alumno.NOMBRE;
                txtMatricula.Text = alumno.MATRICULA.ToString();
                txtContrasena.Text = alumno.CONTRASENA;
                if (alumno.ESTADO == "true")
                {
                    chkbxHabilitado.CheckState = CheckState.Checked;
                }
                else
                {
                    chkbxHabilitado.CheckState = CheckState.Unchecked;
                }
        }
            else
                MessageBox.Show("El Registro no Existe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ALUMNO alumno = new ALUMNO();
                BLL_Alumnos negocio = new BLL_Alumnos();
                alumno = negocio.EliminarAlumno(Convert.ToInt32(txtDni.Text));
                if (alumno.DNI != 0)
                {
                    MessageBox.Show("El Registro ha sido eliminado");
                    txtDni.Clear();
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtNombre.Clear();
                    txtMatricula.Clear();
                    txtContrasena.Clear();
                }
                else
                    MessageBox.Show("El Registro no Existe");
                txtDni.Clear();
                txtApellido.Clear();
                txtNombre.Clear();
                txtMatricula.Clear();
                txtContrasena.Clear();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void FrmAlumno_Load(object sender, EventArgs e)
        {

        }
    }
 }