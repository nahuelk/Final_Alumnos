using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_Materias
    {
        private string CadenaCnx = "";
        private SqlConnection Cnx;
        private SqlCommand Cmd;


        public DAL_Materias()
        {

            CadenaCnx = "Data Source=DESKTOP-S7RLQU8\\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True";

            Cnx = new SqlConnection(CadenaCnx);
            Cnx.Open();


        }

        public Array ListarMaterias(Int32 materias)
        {
            int i = 0;
            string [] array = new string[100];
            Cmd = new SqlCommand("Select * from EXAMEN where id_Catedra="+ materias, Cnx);
            SqlDataReader Dtr = Cmd.ExecuteReader();
            while (Dtr.Read())
                {
                array[i] = Dtr[2].ToString();
                i++;
            }


            return (array);

        }
    }
}
