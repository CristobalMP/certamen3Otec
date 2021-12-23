using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class asignatura
    {
        private int id_asignatura;
        private string nombre_asig;
               
        public asignatura()
        {

        }

        public asignatura(int id_asignatura, string nombre_asig )
        {
            this.id_asignatura = id_asignatura;
            this.nombre_asig = nombre_asig;
        }

        public int Id_asignatura { get => id_asignatura; set => id_asignatura = value; }
        public string Nombre_asig { get => nombre_asig; set => nombre_asig = value; }
    }
}


