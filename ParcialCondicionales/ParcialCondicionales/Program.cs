using System;


namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parcial yupii

            //conjunto de personas debe ser clasificado en 4 grupos, A B C o D
            //tener en cuenta sexo, edad, ultimo digito de cc, manejo del ingles solo si tiene 15 años 

            char sexo;
            byte edad;
            int digito;
            char ingles;

            Console.WriteLine("Ingrese su sexo: " + "\n" + "¿ M o F ?");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());

            if (sexo == 'F')
            {
                if (edad == 15)
                {
                    Console.WriteLine("¿Maneja el inglés?: " + "\n" + " ¿Y o N ?");
                    ingles = Convert.ToChar(Console.ReadLine());
                    if (ingles == 'Y')
                    {
                        Console.WriteLine("Perteneces al grupo C :D");
                    }
                    else if (ingles == 'N')
                    {
                        Console.WriteLine("Perteneces al grupo D :D");
                    }
                    else
                    {
                        Console.WriteLine("Porfa ingresa Y (si) o N (no), en mayúscula :)");
                    }
                }

                else if (edad >= 21 && edad <= 25)
                {
                    Console.WriteLine("Ingrese el último dígito de su documento de identidad: ");
                    digito = Convert.ToByte(Console.ReadLine());

                    if (digito == 3 || digito == 7)
                    {
                        Console.WriteLine("Perteneces al grupo B :D");
                    }
                    else
                    {
                        Console.WriteLine("Perteneces al grupo D :D");
                    }
                }
                else if (edad >= 16 && edad <= 20)
                {
                    Console.WriteLine("Ingrese el último dígito de su documento de identidad: ");
                    digito = Convert.ToByte(Console.ReadLine());

                    if (digito == 0 || digito == 4 || digito == 8)
                    {
                        Console.WriteLine("Perteneces al grupo A :D");
                    }
                    else
                    {
                        Console.WriteLine("Perteneces al grupo D :D");
                    }
                }
                else
                {
                    Console.WriteLine("Perteneces al grupo D :D");
                }
                
            }
            else if (sexo == 'M')
            {
                if (edad >= 18 && edad <= 22)
                {
                    Console.WriteLine("Ingrese el último dígito de su documento de identidad: ");
                    digito = Convert.ToByte(Console.ReadLine());

                    if (digito == 1 || digito == 5 || digito == 9)
                    {
                        Console.WriteLine("Perteneces al grupo A :D");
                    }
                    else
                    {
                        Console.WriteLine("Perteneces al grupo D :D");
                    }
                }
                else if (edad >= 23 && edad <= 26)
                {
                    Console.WriteLine("Ingrese el último dígito de su documento de identidad: ");
                    digito = Convert.ToByte(Console.ReadLine()); 

                    if (digito == 2 || digito == 6)
                    {
                        Console.WriteLine("Perteneces al grupo B :D");
                    }
                    else
                    {
                        Console.WriteLine("Perteneces al grupo D :D");
                    }
                }
                else if (edad == 15)
                {
                    Console.WriteLine("¿Maneja el inglés?: " + "\n" + " ¿Y o N ?");
                    ingles = Convert.ToChar(Console.ReadLine());
                    if (ingles == 'Y')
                    {
                        Console.WriteLine("Perteneces al grupo C :D");
                    }
                    else if (ingles == 'N')
                    {
                        Console.WriteLine("Perteneces al grupo D :D");
                    }
                    else
                    {
                        Console.WriteLine("Porfa ingresa Y (si) o N (no), en mayúscula :)");
                    }
                }
                else
                {
                    Console.WriteLine("Perteneces al grupo D :D");
                }
            }
            else
            {
                Console.WriteLine("Ingrese M o F, en mayúscula plis :)");
            }





        }
    }
}
