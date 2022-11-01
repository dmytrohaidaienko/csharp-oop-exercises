using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_4
{

    /*
    Задание №4:
    Создать класс Tiles (кафель), который будет содержать поля с открытым доступом: brand, size_h, size_w, price и метод класса getData(). 
    В главной функции объявить пару объектов класса и внести данные в поля. Затем отобразить их, вызвав метод getData().
    */

    class Tiles
    {
        public String brand;
        public Int32 size_h;
        public Int32 size_w;
        public Int32 price;

        public void getData()
        {
            Console.WriteLine(" Brand: {0}\n Height size: {1} cm\n Width size: {2} cm\n Price: {3} $", brand, size_h, size_w, price);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Tiles firstTile = new Tiles()
            {
                brand = "CERSANIT",
                size_h = 50,
                size_w = 50,
                price = 20
            };

            Tiles secondTile = new Tiles()
            {
                brand = "FLORIM GROUP",
                size_h = 600,
                size_w = 200,
                price = 130
            };

            Console.WriteLine(" First tile: ");
            firstTile.getData();

            Console.WriteLine();

            Console.WriteLine(" Second tile: ");
            secondTile.getData();
        }
    }
}
