using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    /*
    Задание №1: Абстрактные классы, наследование и полиморфизм.
    1. Создайте класс Dog. 
    2.Наследник Animal.
    3. Реализуйте в нем полиморфный метод eat(), возвращающий строку "Bone".
    */

    internal class Program
    {
        abstract class Animal
        {
            public virtual String Eat()
            {
                return "Bone";
            }
        }

        class Dog : Animal
        {
            public override String Eat()
            {
                return base.Eat();
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog();
            String result = dog.Eat();

            Console.WriteLine(result);
        }
    }
}
