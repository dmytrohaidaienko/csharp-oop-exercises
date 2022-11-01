using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2
{

    /*
    Задание №2:
    В пошаговой стратегии каждый юнит может атаковать.
    Стандартный юнит атакует мечом. Но есть еще два типа юнитов — мушкетеры и маги, атакующие по-своему.
    Напишите программу, которая объявляет класс Unit, который имеет метод Attack(), а он выводит "Using sword!".
    Унаследуйте классы Musketeer и Magician от класса Unit и переопределите его метод Attack() для вывода соответствующих сообщений во время атаки:
    Musketeer => "Using musket!"
    Magician =>"Using magic!"
    */

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine(" Using sword!");
        }
    }

    class Musketeer : Unit
    {
        public override void Attack()
        {
            Console.WriteLine(" Using musket!");
        }
    }

    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine(" Using magic!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Unit unit = new Unit();
            Musketeer musketeer = new Musketeer();
            Magician magician = new Magician();

            unit.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }
}