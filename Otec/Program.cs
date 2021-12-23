using System;
using OtecLibrary;

namespace Otec
{
    class Program
    {
        static void Main(string[] args)
        {
            
            sede Sede = new sede();
            Sede.Nombre_sede = "Los Angeles";
            encargado Encargado = new encargado();
            Encargado.Nombre_encargado = "José Alarcón";
            coordinador Coordinador = new coordinador();
            Coordinador.Nombre_coordinador = "Juan Perez";
            curso Curso = new curso();
            Coordinador.Curso.Nombre_curso = "Ingeniería";
            asignatura Asignatura = new asignatura();
            Curso.Cantidad_asignaturas = 5;
            
            Console.WriteLine("Nombre Sede: " + Sede.Nombre_sede);
            Console.WriteLine("Nombre Encargado: " + Encargado.Nombre_encargado);
            Console.WriteLine("Nombre Coordinador: " + Coordinador.Nombre_coordinador);
            Console.WriteLine("Nombre Curso: " + Coordinador.Curso.Nombre_curso);
            Console.WriteLine("Cantidad asignaturas: " + Curso.Cantidad_asignaturas);
            
            Console.ReadKey();

            
        }
    }
}
