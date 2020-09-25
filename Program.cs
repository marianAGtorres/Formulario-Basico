using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Formulario_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            string edad;
            Console.WriteLine("Edad: ");
            edad = Console.ReadLine();
            f = int.Parse(edad);
            if (f < 18)
            {
                Console.WriteLine("Usted no se puede registrar por ser menor de edad");

            }


        }
    }
       

