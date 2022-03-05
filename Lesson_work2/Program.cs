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
            string maximalTemperature;
            Console.WriteLine("Введите, максимальную температуру ");
            maximalTemperature = Console.ReadLine();
            int x = Convert.ToInt32(maximalTemperature);
            Console.WriteLine("максимальная температура составляет " + maximalTemperature );

            string minimalTemperature;
            Console.WriteLine("Введите, минимальную температуру ");
            minimalTemperature = Console.ReadLine();
            int y = Convert.ToInt32(minimalTemperature);
            Console.WriteLine("Максимальнуа температура составляет " + minimalTemperature );

            int result = (x + y) / 2;
            Console.WriteLine("Средняя температура за сутки " + result);
            Console.ReadLine();
        }
    }
}
