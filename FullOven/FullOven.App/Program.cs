using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullOven.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FullOven 1.0");
            Console.WriteLine("----------------");
            Console.WriteLine("1) О ресторане");
            Console.WriteLine("2) Открыть меню");
            Console.WriteLine("3) Закрыть меню");
            Console.WriteLine("4) Наши места на карте");
            Console.WriteLine("5) Забронировать стол при помощи горячей линии");
            Console.WriteLine("6) Наши контакты");
            Console.WriteLine("0) Выход");
            Console.WriteLine("----------------");
            Console.Write("Выберите пункт меню: ");

            var input = Console.ReadLine();
            Console.WriteLine($"Вы выбрали: {input}");
            Console.WriteLine("Пока это только каркас. Логика появится в следующих ЛР.");
        }
    }
}
