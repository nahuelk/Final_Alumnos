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
        NEGOCIO negocio;
        public FrmAlumno()
        {
            negocio = new NEGOCIO();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            ALUMNOS E = new ALUMNOS();
            E.DNI = Convert.ToInt32(txtDni.Text);
            E.APELLIDO = txtApellido.Text;
            E.NOMBRE = txtNombre.Text;
            E.MATRICULA = Convert.ToInt32(txtMatricula.Text);

            negocio.AltaAlumno(E);

            MessageBox.Show("El registro ha sido dado de alta");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            ALUMNOS E = new ALUMNOS();
            E.DNI = Convert.ToInt32(txtDni.Text);
            E.APELLIDO = txtApellido.Text;
            E.NOMBRE = txtNombre.Text;
            E.MATRICULA = Convert.ToInt32(txtMatricula.Text);

            negocio.ModificarAlumno(E);

            MessageBox.Show("El registro ha sido modificado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ALUMNOS alumno = new ALUMNOS();
            NEGOCIO negocio = new NEGOCIO();
            alumno = negocio.fichaAlumno(Convert.ToInt32(txtDni.Text));
            if (alumno.DNI != 0)
            {
                txtApellido.Text = alumno.APELLIDO;
                txtNombre.Text = alumno.NOMBRE;
                txtMatricula.Text = alumno.MATRICULA.ToString();
            }
            else
                MessageBox.Show("El Registro no Existe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ALUMNOS alumno = new ALUMNOS();
                NEGOCIO negocio = new NEGOCIO();
                alumno = negocio.EliminarAlumno(Convert.ToInt32(txtDni.Text));
                if (alumno.DNI != 0)
                {
                    MessageBox.Show("El Registro ha sido eliminado");
                    txtDni.Clear();
                    txtApellido.Clear();
                    txtNombre.Clear();
                    txtMatricula.Clear();
                }
                else
                    MessageBox.Show("El Registro no Existe");
                txtDni.Clear();
                txtApellido.Clear();
                txtNombre.Clear();
                txtMatricula.Clear();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }