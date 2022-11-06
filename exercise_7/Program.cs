using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace exercise_7
{

    /*
    Задание №7:
    Написать программу, которая определяет абстрактный класс Figure, и наследует от него классы Rectangle и Triangle. 
    Добавьте к классу Figure абстрактный метод Perimeter, затем переопределите его в унаследованных классах для расчета периметров объектов Rectangle и Triangle (они тоже уже созданы). 
    */

    abstract class Figure
    {
        abstract public Int32 Perimeter();
    }

    class Rentangle : Figure
    {
        public Rentangle(Int32 w, Int32 h)
        {
            this.w = w;
            this.h = h;
        }

        public Int32 w { get; set; }
        public Int32 h { get; set; }

        public override Int32 Perimeter()
        {
            return 2 * w + 2 * h;
        }
    }

    class Triangle : Figure
    {
        public Triangle(Int32 s1, Int32 s2, Int32 s3)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
        }

        public Int32 s1 { get; set; }
        public Int32 s2 { get; set; }
        public Int32 s3 { get; set; }

        public override Int32 Perimeter()
        {
            return s1 + s2 + s3;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Figure rentangle = new Rentangle(10, 23);
            Figure triangle = new Triangle(23, 11, 9);

            Int32 rentanglePerimeter = rentangle.Perimeter();
            Int32 trianglePerimeter = triangle.Perimeter();

            Console.WriteLine("Rentangle perimeter: " + rentanglePerimeter);
            Console.WriteLine("Triangle perimeter: " + trianglePerimeter);
        }
    }
}
