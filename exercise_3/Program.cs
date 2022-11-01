using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{

    /*
    Задание №3:
    Реализуйте класс Student (Студент), который будет наследовать от класса User. 
    Этот класс должен иметь следующие свойства: name (имя, наследуется от User), surname (фамилия, наследуется от User), year (год поступления в вуз). 
    Класс должен иметь метод getFullName() (наследуется от User), с помощью которого можно вывести одновременно имя и фамилию студента. 
    Также класс должен иметь метод getCourse(), который будет выводить текущий курс студента (от 1 до 5). 
    Курс вычисляется так: нужно от текущего года отнять год поступления в вуз. Текущий год получите самостоятельно.
    */

    class User
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public Int32 Year { get; set; }

        public void getFullName()
        {
            Console.WriteLine($" Fullname: {Name} {Surname}");
        }

        public void getCourse()
        {
            Console.WriteLine($" Course: {2022 - Year}");
        }
    }

    class Student : User
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Dmytro",
                Surname = "Haidaienko",
                Year = 2019
            };

            student.getFullName();
            student.getCourse();
        }
    }
}