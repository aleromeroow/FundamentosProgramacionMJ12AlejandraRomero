using System;


namespace taller_preparacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer punto

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
          
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("El número mayor es el número 1: " + num1);
                    if (num2 > num3)
                    {
                        Console.WriteLine("El orden de los números es: " + "\n" + num1 + "\n" + num2 + "\n" + num3);
                    }
                    else
                    {
                        Console.WriteLine("El orden de los números es: " + "\n" + num1 + "\n" + num3 + "\n" + num2);
                    }
                }
                else
                {
                    Console.WriteLine("El número mayor es el número 3: " + num3);
                    if (num1 > num2)
                    {
                        Console.WriteLine("El orden de los números es: " + "\n" + num3 + "\n" + num1 + "\n" + num2);
                    }
                    else
                    {
                        Console.WriteLine("El orden de los números es: " + "\n" + num3 + "\n" + num2 + "\n" + num1);
                    }
                }
            }

            else if (num2 > num3)
            {
                Console.WriteLine("El número mayor es el número 2: " + num2);

                if (num3 > num1)
                {
                    Console.WriteLine("El orden de los números es: " + "\n" + num2 + "\n" + num3 + "\n" + num1);
                }
                else
                {
                    Console.WriteLine("El orden de los números es: " + "\n" + num2 + "\n" + num1 + "\n" + num3);
                }
            }
            
            else if (num1 == num2)
                {
                    if (num2 == num3)
                    {
                        if (num3 == num1)
                        {
                            Console.WriteLine("Porfi ingrese números distintos");
                        }
                    }
                }
            else
            {
                
                
                    Console.WriteLine("El número mayor es el número 3: " + num3);
                if (num1 > num2)
                {
                    Console.WriteLine("El orden de los números es: " + "\n" + num3 + "\n" + num1 + "\n" + num2);
                }
                else
                {
                    Console.WriteLine("El orden de los números es: " + "\n" + num3 + "\n" + num2 + "\n" + num1);
                }

            }

            //Punto 2

            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
            Console.WriteLine(numero);







        }
    }
}
