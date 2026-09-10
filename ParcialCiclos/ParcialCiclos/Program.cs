using System;


namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //una institución educativa requiere un programa para procesar el rendimiento académico de los 25 estudiantes del curso de ciencias naturales. por cada estudiante se debe calcular su nota definitiva y determinar si aprobó o reprobó



            float nota = 0;
            float sumanotas = 0;
            int numest = 25;
            float promedio;
            int contadorAprobado = 0;
            int contadorReprobado = 0;
            float sumaPromedio = 0;
            float totalPromedio = 0;

            for (int i = 1; i <= numest; i++)
            {
                nota = 0;
                sumanotas = 0;
                promedio = 0;

                Console.WriteLine($"Escriba las notas del estudiante #{i}");
                Console.WriteLine("Ingrese la nota del exámen #1:");
                nota = Convert.ToSingle(Console.ReadLine());
                sumanotas = sumanotas + nota;
                Console.WriteLine("Ingrese la nota del exámen #2:");
                nota = Convert.ToSingle(Console.ReadLine());
                sumanotas = sumanotas + nota;
                Console.WriteLine("Ingrese la nota del Trabajo de Investigación:");
                nota = Convert.ToSingle(Console.ReadLine());
                sumanotas = sumanotas + nota;

                promedio = sumanotas / 3;

                

                if (promedio >= 3.5f)
                {

                    Console.WriteLine($"El estudiante {i} aprobó :D");
                    contadorAprobado ++;


                } 
                if (promedio <= 3.5f)
                {

                    Console.WriteLine($"El estudiante {i} desaprobó :(");
                    contadorReprobado ++;

                }



                sumaPromedio = sumaPromedio + promedio;

            }

            totalPromedio = sumaPromedio / 25;

            Console.WriteLine($"El total de estudiantes que aprobaron es de {contadorAprobado}");
            Console.WriteLine($"El total de estudiantes que reprobaron es de {contadorReprobado}");
            Console.WriteLine($"El promedio general es de {totalPromedio}");


        }
    }
}
