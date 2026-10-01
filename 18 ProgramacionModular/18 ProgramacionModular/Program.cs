using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cualquier chimbada");
            MostrarMensaje("Ferney");
            MostrarMensaje("Juan");
            Console.ReadKey();
            BorrarPantalla();

        }

        //Funciones sin parámetros

        // procedimiento sin parámetros

        static void BorrarPantalla()
        {

            Console.Clear();
        
        }


        //Procedimiento con parámetros

       static void MostrarMensaje (string nombre)
        {

            Console.WriteLine($"Bienvenido, {nombre} al curso de Fundamentos de Programación");

        }
    }
}
