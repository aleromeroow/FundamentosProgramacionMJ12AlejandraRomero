using System;


namespace _2_Tipos_de_Datos_y_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string gravedad = "9.8";
            string nombre = "Alejandra";
            nombre = "Simón";
            //gravedad="10"; no puedo cambiar el valor de una constante

            //tipos de datos
            byte dato1 = 5; //sin signo
            int dato2 = -4563;
            ulong dato3 = 53453786542;
            float dato4 = 14.6f; //acá si m toca ponerle de sufijo la f para que entienda q es float pq si no lo toma como double
            double dato5 = 45454534564.535648657; //puedo o no pornerle la d como sufijo
            decimal dato6 = 545346542.6857545346857m; //tengo q ponerle el sufijo m de decimal pq si no piensa q es double

            char dato7 = ' ';
            string dato8 = "oisahdoiash4654564¿'¿}´{";
            bool dato9 = false; //true or false

            //Operadores
            //operadores numéricos
            //cambio de signo 
            int dato11 = 5;
            int dato12 = -dato11;
            int dato13 = +dato12;
            int dato14 = -dato13;
            Console.WriteLine("dato11:{0}, dato12:{1}, dato13:{2}, dato14:{3}",dato11,dato12,dato13,dato14);
        }
    }
}
