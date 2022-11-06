using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_5
{

    /*
    Задание №5:
    Программа, которую вы должны создать, должна принимать марку автомобиля в качестве входных данных и определять класс Vehicle с методом ShowBrand().
    Напишите класс Car, чтобы он наследовал класс Vehicle, и добавьте свойство Model и метод ShowModel(), чтобы заданный вызов метода объекта car работал правильно.
    */

    class Vehicle
    {
        public String brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine($"Brand: {brand}");
        }
    }

    class Car : Vehicle
    {
        public Car(String brand, String model)
        {
            this.brand = brand;
            this.model = model;
        }

        public String model { get; set; }

        public void ShowModel()
        {
            Console.WriteLine($"Model: {model}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            String brand = Console.ReadLine();
            String model = Console.ReadLine();

            Car car = new Car(brand, model);

            car.ShowBrand();
            car.ShowModel();
        }
    }
}
