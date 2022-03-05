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
            int month = 3;
            string monthTitle = "";
            switch (month)
            {
                case 1:
                    monthTitle = "январь";
                    break;
                case 2:
                    monthTitle = "февраль";
                    break;
                case 3:
                    monthTitle = "март";
                    break;
                case 4:
                    monthTitle = "апрель";
                    break;
                case 5:
                    monthTitle = "май";
                    break;
                case 6:
                    monthTitle = "июнь";
                    break;
                case 7:
                    monthTitle = "июль";
                    break;
                case 8:
                    monthTitle = "август";
                    break;
                case 9:
                    monthTitle = "сентябрь";
                    break;
                case 10:
                    monthTitle = "октябрь";
                    break;
                case 11:
                    monthTitle = "ноябрь";
                    break;
                case 12:
                    monthTitle = "декабрь";
                    break;
            }

            Console.WriteLine(monthTitle);
            Console.ReadLine();

        }
    }
}
