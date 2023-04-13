using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sNombre;
            int iEdad;
            decimal dIngreso=0;
            DateTime dFechaNacimiento;
            bool bHabilitado=true;
            string sCategoria;
            if (bHabilitado)
            {
                Console.WriteLine("Habilitado");
            }
            else
            {
                Console.WriteLine("Deshabilitado");
            }

            
            
            Console.WriteLine("Ingresar Datos Personales");
            
            Console.WriteLine("Ingrese su nombre");
            sNombre = Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            iEdad = int.Parse(Console.ReadLine());

            if (iEdad>18)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                if (iEdad>13)
                {
                    Console.WriteLine("Adolescente");
                }
                else
                {
                    Console.WriteLine("Niño");
                }
            }

            Console.WriteLine("Ingrese su ingreso");

            if (decimal.TryParse(Console.ReadLine(), out dIngreso))
            {
                Console.WriteLine("Sueldo valido");
            }
      

            Console.WriteLine("Ingrese su fecha de nacimiento");
            dFechaNacimiento = Convert.ToDateTime(Console.ReadLine());
            
            
            Console.WriteLine("Ingrese su categoria");
            Console.WriteLine("A: Administrativo");
            Console.WriteLine("M: Mantenimiento");
            Console.WriteLine("S: Sistemas");
            sCategoria = Console.ReadLine();

            switch (sCategoria.ToUpper())
            {
                case "A":
                    Console.WriteLine("Administrativo");
                    break;

                case "M":
                    Console.WriteLine("Mantenimiento");
                    break;
                case "S":
                    Console.WriteLine("Sistemas");
                    break;
                default:
                    Console.WriteLine("Categoria invalida");
                    break;
            }

            Console.ReadKey();




        }
    }
}
