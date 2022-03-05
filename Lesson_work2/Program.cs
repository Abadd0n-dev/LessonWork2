using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Введите число:");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Введено четное число");
                Console.Read();
            }
            else
            {
                Console.Write("Введено нечетное число");
                Console.Read();
            }
        }
    }
}
