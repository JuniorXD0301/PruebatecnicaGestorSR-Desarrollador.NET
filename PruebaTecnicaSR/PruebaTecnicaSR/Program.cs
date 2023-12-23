using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSR
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("Media Aritmetica: " + Agent.MediaAritmetica(numbers));
            Console.WriteLine("Media Armonica: " + Agent.MediaArmonica(numbers));
            Console.WriteLine("Mediana: " + Agent.Mediana(numbers));

            int n = 5;

            Console.WriteLine("Escalera A:\n" + Agent.StaircaseA(n));
            Console.WriteLine("Escalera B:\n" + Agent.StaircaseB(n));
            Console.WriteLine("Escalera C:\n" + Agent.StaircaseC(n));

            Console.Read();
        }


    }
}
