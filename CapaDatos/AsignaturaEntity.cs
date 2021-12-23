using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtecLibrary;

namespace CapaDatos
{
    public class AsignaturaEntity
    {
        Datos data = new Datos();

        public List<asignatura> listado()
        {

            DataSet respuesta = data.listado("SELECT * FROM cm_cn_asignatura");

            List<asignatura> listadoAsignatura = new List<asignatura>();

            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                asignatura asigna = new asignatura(int.Parse(item.ItemArray[0].ToString()), item.ItemArray[1].ToString());
                listadoAsignatura.Add(asigna);
            }

            return listadoAsignatura;
        }

        public List<asignatura> listado(int id_asignatura)
        {
            DataSet respuesta = data.listado("SELECT * FROM cm_cn_asignatura WHERE id_asignatura ='" + id_asignatura.ToString() + "'");

            List<asignatura> listadoAsignatura = new List<asignatura>();

            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                asignatura asigna = new asignatura(int.Parse(item.ItemArray[0].ToString()), item.ItemArray[1].ToString());
                listadoAsignatura.Add(asigna);
            }
            return listadoAsignatura;
        }

        public int guardar(asignatura asigna)
        {
            return data.ejecutar("Insert into cm_cn_asignatura(id_asignatura, nombre_asig) values('" + asigna.Id_asignatura.ToString() + "','" + asigna.Nombre_asig + "')");
        }

        public int eliminar(int id_asignatura)
        {
            return data.ejecutar("DELETE FROM cm_cn_asignatura WHERE id_asignatura = '" + id_asignatura.ToString() + "'");
        }

        public int editar(asignatura asigna)
        {
            return data.ejecutar("UPDATE cm_cn_asignatura SET nombre_asig = '" + asigna.Nombre_asig + "' WHERE id_asignatura = '" + asigna.Id_asignatura.ToString() + "'");
        }

    }
}
