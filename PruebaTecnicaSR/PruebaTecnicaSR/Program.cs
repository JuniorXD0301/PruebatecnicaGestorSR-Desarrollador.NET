using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaSR
{
    public class Agent
    {
        public delegate double GetMedia(List<double> numbers);

        public static double MediaAritmetica(List<double> numbers)
        {
            return numbers.Average();
        }

        public static double MediaArmonica(List<double> numbers)
        {
            return numbers.Count / numbers.Sum(x => 1 / x);
        }

        public static double Mediana(List<double> numbers)
        {
            var sortedNumbers = numbers.OrderBy(n => n).ToList();
            var count = sortedNumbers.Count;
            if (count % 2 == 0)
            {
                return (sortedNumbers[count / 2 - 1] + sortedNumbers[count / 2]) / 2;
            }
            else
            {
                return sortedNumbers[count / 2];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Media Aritmetica: " + Agent.MediaAritmetica(numbers));
            Console.WriteLine("Media Armonica: " + Agent.MediaArmonica(numbers));
            Console.WriteLine("Mediana: " + Agent.Mediana(numbers));
        }


    }
}
