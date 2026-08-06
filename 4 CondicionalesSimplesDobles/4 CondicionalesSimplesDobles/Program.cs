using System;

namespace _4_CondicionalesSimplesDobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructuras de control condicionales 
            //simples
            //crea un algoritmo que le a la edad de un usuario, si es mayor de 18 se debe mostrar el siguiente mensaje "bienvenido a mi página web"

            /* byte edad = 0;
             Console.WriteLine("Ingrese su edad");
             edad = Convert.ToByte ( Console.ReadLine() );
             if(edad>=18)
             {
                 Console.WriteLine("eh Brazino el juego de esta era");
             }*/
            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos debe mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos

            
            string nombre;
            int sueldo = 0;
            Console.WriteLine("ingrese su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo");
            sueldo = Convert.ToInt32 (Console.ReadLine());
            if(sueldo>=3000)
            {
                Console.WriteLine("Hola " + nombre + ", debes declarar impuestos");
            }

            //Condicionales dobles
            //crea un algoritmo que le a la edad de un usuario, si es mayor de 18 se debe mostrar el siguiente mensaje "bienvenido a mi página web", si no q le diga q no puede entrar
            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("eh Brazino el juego de esta era");
            }
            else 
            {
                Console.WriteLine("Tú conoces a pin pon?");
                string jaja = Console.ReadLine();
                Console.WriteLine("Si, pin pon");
                string jajaja = Console.ReadLine();
                Console.WriteLine("Si, se lava su carita con agua y con jabón");
                string jajajaja = Console.ReadLine();
                Console.WriteLine("SI, SE LAVA LA CARITA");


            }

        }
    }
}
