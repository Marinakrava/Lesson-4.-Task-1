using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4.Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + Math.Pow((2 * i - 1), 2);

            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

}
