using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculador_de_caloria
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string peso;
            float Calculador_de_calorias;
            Console.WriteLine("Escribe tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Escribir tu peso corporal en kg");
            peso = Console.ReadLine();
            Calculador_de_calorias = int.Parse(peso) * 19;
            Console.WriteLine( Nombre + " usted necesita {0} calorias por dia ", Calculador_de_calorias);
            Console.Read();
        }
    }
}
