using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class direccion
    {
        private string calle;
        private int numero;
        private string ciudad;

        public direccion()
        {

        }
        public direccion(string calle, int numero, string ciudad)
        {
            this.calle = calle;
            this.numero = numero;
            this.ciudad = ciudad;
        }
        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
    }
}
