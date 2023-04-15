using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание экз-ра кофе
            Beverage es = new Espresso();

            //Добавление добавок в кофе еспрессо
            es = new Milk(es);

            Console.WriteLine($"{es.GetDescription()} " + $"${es.Cost()} ");

            Console.ReadKey();
        }
    }
}
