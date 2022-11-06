using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_6
{

    /*
    Задание №6:
    Написать программу, которая получает номер счета и его баланс в качестве вводных данных. 
    Она определяет класс Account с одним членом balance и наследует из него класс User с одним дополнительным членом – номером аккаунта (AccNumber), 
    затем создает объект user и пытается сохранить в нем баланс и номер счета, а также отображает банковские данные. Но что-то пошло не так. 
    Исправить программу таким образом, чтобы она завершала работу конструктора User(), который должен присваивать параметры соответствующим членам класса User. 
    Так же, проверьте модификатор доступа члена balance класса Account. 

    Пример вводных данных 
    005615216 
    1488.36 

    Пример результата 
    Account N: 005615216 
    Balance: 1488.36
    */

    class Account
    {
        public Double Balance { get; set; }
    }

    class User : Account
    {
        public User(String numbr, Double balance)
        {
            AccNumber = numbr;
            Balance = balance;
        }

        public String AccNumber { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            String numbr = Console.ReadLine();
            Double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(numbr, balance);

            user.ShowDetails();
        }
    }
}
