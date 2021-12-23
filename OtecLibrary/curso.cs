using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class curso
    {
        private int id_curso;
        private string nombre_curso;
        private asignatura asignatura = new asignatura();
        private int cantidad_asignaturas;

        public curso()
        {
        
        }

        public curso(int id_curso, string nombre_curso)
        {
            this.id_curso = id_curso;
            this.nombre_curso = nombre_curso;
        }

        public int Id_curso { get => id_curso; set => id_curso = value; }
        public string Nombre_curso { get => nombre_curso; set => nombre_curso = value; }
        public asignatura Asignatura { get => asignatura; set => asignatura = value; }
        public int Cantidad_asignaturas { get => cantidad_asignaturas; set => cantidad_asignaturas = value; }
    }
}
