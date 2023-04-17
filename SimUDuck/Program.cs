using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаем экземпляр класса утки
            //Duck duck1 = new MallardDuck();

            ////Выводим сведения(тип утки и её поведение)
            //Console.WriteLine($"{duck1.Swim()} " + $"{duck1.Display()}");
            //Console.WriteLine($"{duck1.PerformFly()} ");
            //Console.WriteLine($"{duck1.PerformQuack()}");

            ////Создаем экземпляр поведения утки
            //FlyBehavior flyBehavior = new FlyWithWings();
            //QuackBehavior quackBehavior = new Squeak();

            ////Меняем поведение утки
            //duck1.SetQuackBehavior(quackBehavior);
            //duck1.SetFlyBehavior(flyBehavior);

            ////Выводим новые сведения(тип утки и её новое поведение)
            //Console.WriteLine($"{duck1.Display()} ");
            //Console.WriteLine($"{duck1.PerformFly()} ");
            //Console.WriteLine($"{duck1.PerformQuack()}");
            int[,] array = new int[4, 2] { { 4, 4 }, { 4, 4 }, { 4, 4 }, { 4, 4 } };

            Test.Method(array, 2);

            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
