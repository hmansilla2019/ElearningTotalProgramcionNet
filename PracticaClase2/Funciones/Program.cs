using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sueldo = 0;
            Saludo("Hugo");
            Console.WriteLine("Precio " + PrecioVenta(10, 100));

            Console.WriteLine("Categoria: " + Categoria("A", ref Sueldo));
            Console.WriteLine("Sueldo: " + Sueldo);

            Break();



        }

        static void Saludo(string Nombre)
        {
            Console.WriteLine("Hola " + Nombre);
        }

        static void Break()
        {
            Console.ReadKey();
        }

        static int PrecioVenta(int cantidad, int precioUnitario)
        {
            return cantidad * precioUnitario;
        }

        static string Categoria(string CodCategoria, ref int Sueldo)
        {
            string Categoria;

            switch (CodCategoria.ToUpper())
            {
                case "A":
                    Categoria = "Administrativo";
                    Sueldo = 100000;
                    break;

                case "M":
                    Categoria = "Mantenimiento";
                    Sueldo = 200000;
                    break;
                case "S":
                    Categoria = "Sistemas";
                    Sueldo = 1000000;
                    break;
                default:
                    Categoria = "Categoria invalida";
                    break;
            }
            return Categoria;
        }
    }
}
