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
            Console.WriteLine("1) Добавить задачу (пока заглушка)");
            Console.WriteLine("2) Показать список задач (пока заглушка)");
            Console.WriteLine("3) Изменить статус задачи (пока заглушка)");
            Console.WriteLine("4) Удалить задачу (пока заглушка)");
            Console.WriteLine("0) Выход");
            Console.WriteLine("----------------");
            Console.Write("Выберите пункт меню: ");

            var input = Console.ReadLine();
            Console.WriteLine($"Вы выбрали: {input}");
            Console.WriteLine("Пока это только каркас. Логика появится в следующих ЛР.");

        }
    }
}
