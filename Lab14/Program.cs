using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Мурка";
            cat.Say();
            cat.ShowInfo();

            Console.WriteLine();

            Dog dog = new Dog();
            dog.Name = "Бобик";
            dog.Say();
            dog.ShowInfo();

            Console.WriteLine();

            //проверим конструктор абстрактного класса
            Dog unit = new Dog();
            unit.Say();
            unit.ShowInfo();

            Console.ReadKey();

        }
    }
}
