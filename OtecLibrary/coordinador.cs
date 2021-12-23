using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class coordinador
    {
        private int id_coordinador;
        private string rut;
        private string nombre_coordinador;
        private string telefono;
        private direccion direccion = new direccion();
        private string email;
        private curso curso = new curso();

        public coordinador()
        {

        }

        public coordinador(int id_coordinador, string rut, string nombre_coordinador)
        {
            this.id_coordinador = id_coordinador;
            this.rut = rut;
            this.nombre_coordinador = nombre_coordinador;
        }

        public int Id_coordinador { get => id_coordinador; set => id_coordinador = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public direccion Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public curso Curso { get => curso; set => curso = value; }
        public string Nombre_coordinador { get => nombre_coordinador; set => nombre_coordinador = value; }
    }
}
