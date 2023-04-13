using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sNombre;
            int iContador=1;
            
            // Quiero mostrar por pantalla
            // la tabla del 2
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i * 2);
            //}
            

            // Cargar 10 nombres
            //for (int i = 1; i < 11; i++)
            //{

            //    Console.WriteLine("Ingrese el nombre de la persona" + i);
            //    sNombre = Console.ReadLine();
            //}

            //while (iContador < 4)
            //{
            //    Console.WriteLine("Ingrese el nombre de la persona " + iContador);
            //    sNombre = Console.ReadLine();
            //    iContador++;
            //}

            do
            {
                Console.WriteLine("Ingrese el nombre de la persona " + iContador);
                sNombre = Console.ReadLine();
                iContador++;
            } while (iContador < 4);

            Console.ReadKey();


        }
    }
}
