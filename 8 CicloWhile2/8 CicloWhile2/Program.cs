using System;


namespace _8_CicloWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 

            int sumaEnteros = 0;
            int numero = 0;
            Console.WriteLine("Ingrese un número para sumar: ");
            numero = int.Parse(Console.ReadLine());

            while (numero >= 0)
            {
                sumaEnteros += numero;
                Console.WriteLine("Ingrese un número para sumar: ");
                numero = int.Parse(Console.ReadLine());
            } 

            Console.WriteLine("La suma de los números es: " + sumaEnteros);

        }
    }
}
