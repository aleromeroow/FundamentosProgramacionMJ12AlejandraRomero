using System;


namespace _5_CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicionales Anidados
            //3 numeros y mire avr cual es el mayor
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("Ingrese 3 valores distintos");
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = int.Parse( Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El número mayor es " + num1);
                }
                else
                {
                    Console.WriteLine("El número mayor es " + num3);
                }
            }

            else if (num2 > num3) 
            {
                Console.WriteLine("El número mayor es " + num2);
            }
            else 
            {
                Console.WriteLine("El número mayor es " + num3);
            }
        }
    }
}
