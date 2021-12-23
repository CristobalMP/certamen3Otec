using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class sede
    {
        private int id_sede;
        private string nombre_sede;
        private direccion direccion = new direccion();
        private string telefono;
        private string email;

        public sede()
        {

        }

        public sede(int id_sede, string nombre_sede)
        {
            this.id_sede = id_sede;
            this.nombre_sede = nombre_sede;
        }

        public int Id_sede { get => id_sede; set => id_sede = value; }
        public string Nombre_sede { get => nombre_sede; set => nombre_sede = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public direccion Direccion { get => direccion; set => direccion = value; }
    }
}
