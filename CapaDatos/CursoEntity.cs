using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtecLibrary;

namespace CapaDatos
{
    public class CursoEntity
    {
        Datos data = new Datos();

        public List<curso> listado()
        {

            DataSet respuesta = data.listado("SELECT * FROM cm_cn_curso");

            List<curso> listadoCurso = new List<curso>();

            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                curso cur = new curso(int.Parse(item.ItemArray[0].ToString()), item.ItemArray[1].ToString(), int.Parse(item.ItemArray[2].ToString()));

                listadoCurso.Add(cur);
            }

            return listadoCurso;
        }

        public List<curso> listado(int id_curso)
        {
            DataSet respuesta = data.listado("SELECT * FROM cm_cn_curso WHERE id_curso ='" + id_curso.ToString() + "'");

            List<curso> listadoCurso = new List<curso>();

            foreach (DataRow item in respuesta.Tables[0].Rows)
            {
                curso cur = new curso(int.Parse(item.ItemArray[0].ToString()), item.ItemArray[1].ToString(), int.Parse(item.ItemArray[2].ToString()));
                listadoCurso.Add(cur);
            }
            return listadoCurso;
        }

        public int guardar(curso cur)
        {
            return data.ejecutar("INSERT INTO cm_cn_curso(id_curso, nombre_curso, can_asignatura) values('" + cur.Id_curso.ToString() + "','" + cur.Nombre_curso + "', '" + cur.Cantidad_asignaturas.ToString() + "' )");
        }

        public int eliminar(int id_curso)
        {
            return data.ejecutar("DELETE FROM cm_cn_curso WHERE id_curso = '" + id_curso.ToString() + "'");
        }

        public int editar(curso cur)
        {
            return data.ejecutar("UPDATE cm_cn_curso SET nombre_curso = '" + cur.Nombre_curso + "', can_asignatura = '" + cur.Cantidad_asignaturas.ToString() + "' WHERE id_curso = '" + cur.Id_curso.ToString() + "'");
        }

    }
}
