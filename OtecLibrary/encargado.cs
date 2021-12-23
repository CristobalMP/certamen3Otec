using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class encargado
    {
        private int id_encargado;
        private string rut;
        private string nombre_encargado;
        private direccion direccion = new direccion();
        private string telefono;
        private string email;

        public encargado()
        {

        }

        public encargado(int id_encargado, string rut, string nombre_encargado)
        {
            this.id_encargado = id_encargado;
            this.rut = rut;
            this.nombre_encargado = nombre_encargado;
        }

        public int Id_encargado { get => id_encargado; set => id_encargado = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre_encargado { get => nombre_encargado; set => nombre_encargado = value; }
        public direccion Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
    }
}

