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

        public delegate string GetStaircase(int n);

        public static string StaircaseA(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += new String(' ', n - i) + new String('#', i) + "\n";
            }
            return result;
        }

        public static string StaircaseB(int n)
        {
            string result = "";
            for (int i = n; i >= 1; i--)
            {
                result += new String(' ', n - i) + new String('#', i) + "\n";
            }
            return result;
        }

        public static string StaircaseC(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += new String(' ', Math.Abs(n - i)) + new String('#', 2 * i - 1) + "\n";
            }
            for (int i = n - 1; i >= 1; i--)
            {
                result += new String(' ', Math.Abs(n - i)) + new String('#', 2 * i - 1) + "\n";
            }
            return result;
        }
    }
}
