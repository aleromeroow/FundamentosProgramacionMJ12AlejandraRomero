using System;


namespace _3_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operadores numéricos
            //incemebti decremento
            int dato1 = 0;
            dato1++; //lo incrementa en 1 unidad
            dato1--; //lo decrementa en 1 unidad
            dato1 += 15; //le sumo 15 
            dato1 -= 14; //le resto 14 
            dato1 *= 3; //lo multiplico por 3
            dato1 /= 2; //lo divido en 2
            dato1 *= dato1; //se entiende :P

            //orden de evaluación (lo q primero se hace) 1. () 2. * / 3. + - 

            //operadores lógicos (toda esa mierda tiene tablas, revise las tablas >:( ) 
            //and , Y , && son los de conjunción 
            Console.WriteLine("Tabla de conjunción");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));

            //or, o , || son los de disyunción 
            Console.WriteLine("Tabla de disyunción");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));

        }
    }
}
