using System;

namespace prueba_formulario
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string Ocupacion;
            string Correo;
            string Telefono;
            int a;

            Console.WriteLine("Hola, Ingresa los siguienetes datos, para realizar tu registro");
            Console.WriteLine("Nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su edad:  ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ocupacion: ");
            Ocupacion = Console.ReadLine();

            Console.WriteLine("Correo: ");
            Correo = Console.ReadLine();

            Console.WriteLine("Telefono ");
            Telefono = Console.ReadLine();


            if (a >= 18)
            {
                Console.WriteLine("Bienvenido  tu registro ha sido Exitoso!");

            }
            else
            {
                Console.WriteLine("Lo sentimos por ser menor de edad no puedes continuar");
            }

        }
    }
}


