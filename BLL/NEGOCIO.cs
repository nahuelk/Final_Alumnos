using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;
using System.Windows.Forms;

namespace BLL
{
    public class NEGOCIO
    {

        DATOS dato;

        public NEGOCIO()
        {
            dato = new DATOS();
        }

        public void AltaAlumno(ALUMNO alumno)
        {

            dato.Agregar(alumno);


        }

        public void ModificarAlumno(ALUMNO alumno)
        {

            dato.Modificar(alumno);


        }


        public void MostrarTabla(DataGridView Dtg, string tabla)
        {
            Dtg.DataSource = dato.MostrarTabla(tabla);

        }

        public void ExportarXml (string ruta, string tabla)
        {

            dato.Exportar(tabla, ruta);


        }

        public void ExportarCsv (string path, string table)
        {
            dato.ExportarCsv(path, table);
        }

        public void ImportarArchivo(string archivo)
        {
            dato.ImportarPlano(archivo);

        }

        public void ImportardesdeXML(string archivo)
        {
            dato.ImportarXML(archivo);
        }


        public ALUMNO fichaAlumno(Int32 dniAlumno)
        {
            return dato.ficha(dniAlumno);

        }

        public ALUMNO EliminarAlumno(Int32 dniAlumno)
        {
            return dato.Eliminar(dniAlumno);

        }
    }
}
