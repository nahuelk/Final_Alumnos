using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using ENTITY;
using System.Data;
using System.Xml;



namespace DAL
{
    public class DAL_Alumnos
    {

        private string CadenaCnx = "";
        private SqlConnection Cnx;
        private SqlCommand Cmd;


        public DAL_Alumnos()
        {

            CadenaCnx = "Data Source=DESKTOP-S7RLQU8\\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True";

            Cnx = new SqlConnection(CadenaCnx);
            Cnx.Open();


        }

        public DAL_Alumnos(string cadena)
        {

            CadenaCnx = cadena;

            Cnx = new SqlConnection(CadenaCnx);
            Cnx.Open();

        }

        public void Agregar(ALUMNO alumno)
        {
            string StrSql = "Insert into ALUMNOS (dni, apellido, nombre, matricula, contrasena, estado) values(" + alumno.DNI.ToString() + ",'" + alumno.APELLIDO + "','" + alumno.NOMBRE + "','" + alumno.MATRICULA.ToString() + "','" + alumno.CONTRASENA + "','" + alumno.ESTADO + "')";
            Cmd = new SqlCommand(StrSql, Cnx);
            Cmd.ExecuteNonQuery();

        }

        public void Modificar(ALUMNO alumno)
        {
            string StrSql = "UPDATE ALUMNOS SET apellido='" + alumno.APELLIDO + "',nombre='" + alumno.NOMBRE + "',matricula='" + alumno.MATRICULA.ToString() + "',contrasena='" + alumno.CONTRASENA + "',estado='" + alumno.ESTADO + "'Where dni=" + alumno.DNI.ToString();
            Cmd = new SqlCommand(StrSql, Cnx);
            Cmd.ExecuteNonQuery();

        }

        public DataTable MostrarTabla(string tabla)
        {
            DataTable Dtt = new DataTable();
            SqlDataAdapter Ada = new SqlDataAdapter("Select * from " + tabla, Cnx);
            Ada.Fill(Dtt);

            return (Dtt);

        }


        public void Exportar(string Tabla, string ruta)
        {
            DataSet Dts = new DataSet();
            SqlDataAdapter Ada = new SqlDataAdapter("Select * from " + Tabla, Cnx);
            Ada.Fill(Dts, Tabla);

            Dts.WriteXml(ruta);

        }


        public void ExportarCsv(string ruta, string tabla)
        {

            StreamWriter archivo = new StreamWriter(ruta);

            Cmd = new SqlCommand("Select * from " + tabla, Cnx);

            SqlDataReader Dtr = Cmd.ExecuteReader();

            while (Dtr.Read())
            {
                string linea = Dtr[0].ToString() + ";" + Dtr[1].ToString() + ";" + Dtr[2].ToString() + ";" + Dtr[3].ToString() + ";" + Dtr[4].ToString() + ";" + Dtr[5].ToString();
                archivo.WriteLine(linea);

            }

            archivo.Close();



        }


        public void ImportarPlano(string nombreArchivo)
        {
            StreamReader archivo = new StreamReader(nombreArchivo, Encoding.UTF8);

            string encabezado = archivo.ReadLine();

            while (archivo.Peek() > 1)
            {
                string[] registro;
                //archivo.ReadLine();
                registro = archivo.ReadLine().Split(';');

                Cmd = new SqlCommand("Insert into ALUMNOS(dni, apellido, nombre, matricula, contrasena, estado) values(" + registro[0] + ",'" + registro[1] + "','" + registro[2] + "','" + registro[3] + "','" + registro[4] + "','" + registro[5] + "')", Cnx);
                Cmd.ExecuteNonQuery();


            }



        }

        public void ImportarXML(string nombreArchivo)
        {
            ALUMNO alumno = new ALUMNO();

            using (XmlReader reader = XmlReader.Create(nombreArchivo))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "DNI":
                                alumno.DNI = Convert.ToInt32(reader.ReadString());
                                break;
                            case "APELLIDO":
                                alumno.APELLIDO = reader.ReadString();
                                break;
                            case "NOMBRE":
                                alumno.NOMBRE = reader.ReadString();
                                break;
                            case "MATRICULA":
                                alumno.MATRICULA = Convert.ToInt32(reader.ReadString());
                                break;
                            case "CONTRASENA":
                                alumno.CONTRASENA = reader.ReadString();
                                break;
                            case "ESTADO":
                                alumno.ESTADO = reader.ReadString();
                                Cmd = new SqlCommand("Insert into ALUMNOS(dni, apellido, nombre, matricula) values(" + alumno.DNI + ",'" + alumno.APELLIDO + "','" + alumno.NOMBRE + ",'" + alumno.MATRICULA + ",'" + alumno.CONTRASENA + ",'" + alumno.ESTADO + "')", Cnx);
                                Cmd.ExecuteNonQuery();
                                break;
                        }

                    }

                }
            }

        }

        public ALUMNO ficha(Int32 dni)
        {
            ALUMNO alumno = new ALUMNO();

        Cmd = new SqlCommand("Select * from ALUMNOS where dni=" + dni, Cnx);

            SqlDataReader Dtr = Cmd.ExecuteReader();
            if (Dtr.Read())
            {
                alumno.DNI = dni;
                alumno.APELLIDO = Dtr[1].ToString();
                alumno.NOMBRE = Dtr[2].ToString();
                alumno.MATRICULA = Convert.ToInt32(Dtr[3]);
                alumno.CONTRASENA = Dtr[4].ToString();
                alumno.ESTADO = Dtr[5].ToString();

            }
            else
                alumno.DNI = 0;
            return alumno;
        }



        public ALUMNO Eliminar(Int32 dni)
        {
            ALUMNO alumno = new ALUMNO();


            
        Cmd = new SqlCommand("Select * from ALUMNOS where dni=" + dni, Cnx);

            SqlDataReader Dtr = Cmd.ExecuteReader();
            if (Dtr.Read())
            {
                alumno.DNI = dni;
                alumno.APELLIDO = Dtr[1].ToString();
                alumno.NOMBRE = Dtr[2].ToString();
                alumno.MATRICULA = Convert.ToInt32(Dtr[3]);
                alumno.CONTRASENA = Dtr[4].ToString();
                alumno.ESTADO = Dtr[5].ToString();

            }
            else
                alumno.DNI = 0;

            Dtr.Close();

            Cmd = new SqlCommand("Delete from EMPLEADOS where dni=" + dni, Cnx);
            Cmd.ExecuteNonQuery();


            return alumno;
        }



    }
}
