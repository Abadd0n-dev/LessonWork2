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
            Console.Title = "Чек";
            Console.WindowWidth = 70;
            Console.WindowHeight = 40;
            Console.WriteLine("{0,35}", "Пятерочка");
            Console.WriteLine("{0,37}", "Кассовый чек");
            Console.WriteLine("{0,20}", "Цена до скидки       Скидка      Итого");
            double price = 35.99;
            Console.WriteLine("Вода СВЯТОЙ ИСТОЧНИК б/г" + "{0, 15}", price );
            for (int i = 0; i < 100; i++)
                Console.Write("-");
            Console.WriteLine();          
            Console.WriteLine("ПОДЫТОГ: " + price);
            int total = 35;
            Console.WriteLine("ИТОГ: " + total);
            Console.WriteLine("СДАЧА: " + total);
            int change = 0;
            Console.WriteLine("СДАЧА: " + change);
            for (int i = 0; i < 100; i++)
                Console.Write("-");
            Console.WriteLine();
            string name = "Джафарова Сакина Вагибовна";
            Console.WriteLine("Кассир: " + name + ", Продавец-кассир");
            Console.WriteLine($"Дата принятия: [{ DateTime.Now}]");
            Console.ReadLine();
        }
    }
}
