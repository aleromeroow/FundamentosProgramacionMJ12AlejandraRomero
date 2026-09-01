using System;


namespace _11_CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////ciclo do while 
            //int contador = 1;
            //int acumulador = 0;

            //do
            //{
            //    acumulador += contador;
            //    contador++;
            //} while (contador <= 5);

            //Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");


            int numero = 0;
            int contador = 1;
            char continuar;
            do
            {
                Console.WriteLine("Escriba el número del que quiere sacar la tabla de multiplicar hasta el 10: ");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine(numero * contador);
                    contador++;
                    

                } while (contador <= 10);

                Console.WriteLine("¿Desea continuar? ");
                continuar = char.Parse(Console.ReadLine());
                contador = 1;

            } while (continuar == 'Y' || continuar == 'Y');

            Console.WriteLine("fin :)");

            //m faltó hacer un ejercicio
        }
    }
}
