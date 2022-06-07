using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yumakov.atm
{
   abstract class Score
   {
        protected double score;
        public abstract void showScore(); 
        // Посмотреть баланс
        public abstract void takeОff(double minusMoney); 
        // Снять деньги
        public abstract void topUp(double plusMoney); 
        // Пополнить баланс
   }
    class CreditScore : Score
    {
        public double score_
        {
            get 
            {
                if (score < 0)
                {
                    Console.WriteLine("У вас баланс меньше 0, пожалуйста, пополните счёт");
                }
                return (int)score;
            }
            set
            {
                if (score < 0)
                {
                    Console.WriteLine("Пополните баланс. Операция снятия запрещена");
                }
            }
        }
        public CreditScore()
        {
            score = 0;
        }
        public CreditScore(int score)
        {
            this.score = score;
        }
        public override void showScore()
        {
            Person MYumakov = new Person("Максим", "Юмаков", "Владиславович");
            MYumakov.ShowPerson();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
        }

        public override void takeОff(double minusMoney)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс до снятия денег: {0} ₽", score);
            Console.ResetColor();
            score -= minusMoney;
            Console.WriteLine("Снятие прошло успешно");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы сняли {0} ₽", minusMoney);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
            Console.WriteLine();
        }

        public override void topUp(double plusMoney)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс до внесения денег: {0} ₽", score_);
            Console.ResetColor();
            score += plusMoney;
            Console.WriteLine("Пополнение прошло успешно");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы пополнили баланс на {0} ₽", plusMoney);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
            Console.WriteLine();
        }
        public static bool operator <=(CreditScore c1, CreditScore c2)
        {
            if (c1.score_ <= c2.score_)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(CreditScore c1, CreditScore c2)
        {
            if (c1.score_ >= c2.score_)
            {
                return true;
            }
            return false;
        }
        ~CreditScore()
        {
            Console.WriteLine("Объект разрушен");
        }
    }
    class DebetScore : Score
    {
        public double score_
        {
            get
            {
                if (score < 0)
                {
                    Console.WriteLine("У вас баланс меньше 0, пожалуйста, пополните счёт");
                }
                return (int)score;
            }
            set
            {
                if (score < 0)
                {
                    Console.WriteLine("Пополните баланс. Операция снятия запрещена");
                }
            }
        }
        public DebetScore()
        {
            score = 0;
        }
        public DebetScore(int score)
        {
            this.score = score;
        }
        public override void showScore()
        {
            Person APavlenko = new Person("Артём","Павленко","Евгеньевич");
            APavlenko.ShowPerson();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
        }

        public override void takeОff(double minusMoney)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс до снятия денег: {0} ₽", score_);
            Console.ResetColor();
            score -= minusMoney;
            Console.WriteLine("Снятие прошло успешно");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы сняли {0} ₽", minusMoney);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
            Console.WriteLine();
        }

        public override void topUp(double plusMoney)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс до внесения денег: {0} ₽", score_);
            Console.ResetColor();
            score += plusMoney;
            Console.WriteLine("Пополнение прошло успешно");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы пополнили баланс на {0} ₽", plusMoney);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
            Console.WriteLine();
        }
        public static bool operator <=(DebetScore c1, DebetScore c2)
        {
            if (c1.score_ <= c2.score_)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(DebetScore c1, DebetScore c2)
        {
            if (c1.score_ >= c2.score_)
            {
                return true;
            }
            return false;
        }
        ~DebetScore()
        {
            Console.WriteLine("Объект разрушен");
        }
    }
    class GoldScore : DebetScore
    {
        public GoldScore()
        {
            score = 0;
        }
        public GoldScore(int score)
        {
            this.score = score;
        }
        public override void showScore()
        {
            Person AShevchenko = new Person("Андрей", "Шевченко", "Михайлович");
            AShevchenko.ShowPerson();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
        }
        public override void takeОff(double minusMoney)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс до снятия денег: {0} ₽", score_);
            Console.ResetColor();
            score -= minusMoney;
            double cashback = score * 0.2;
            score += cashback; 
            Console.WriteLine("Снятие прошло успешно");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вы сняли {0} ₽", minusMoney);
            Console.WriteLine("Ваш кешбек составил: {0} ₽", cashback);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
            Console.WriteLine();

        }
        public override void topUp(double plusMoney)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс до внесения денег: {0} ₽", score_);
            Console.ResetColor();
            score += plusMoney;
            double cashback = score * 0.1;
            score += cashback;
            Console.WriteLine("Пополнение прошло успешно");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы пополнили баланс на {0} ₽", plusMoney);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ваш кешбек составил: {0} ₽", cashback);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
            Console.ResetColor();
            Console.WriteLine();

        }
        public static bool operator <=(GoldScore c1, GoldScore c2)
        {
            if (c1.score_ <= c2.score_)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(GoldScore c1, GoldScore c2)
        {
            if (c1.score_ >= c2.score_)
            {
                return true;
            }
            return false;
        }
        ~GoldScore()
        {
            Console.WriteLine("Объект разрушен");
        }
    }
    class Person
    {
        protected string name, surname, firstname;
        public string name_
        {
            get 
            {
                return name;
            }
            set
            {
                if(name == "")
                {
                    Console.WriteLine("Значение не может быть пустым");
                }
            }
        }
        public string surname_
        {
            get
            {
                return surname;
            }
            set
            {
                if (surname == "")
                {
                    Console.WriteLine("Значение не может быть пустым");
                }
            }
        }
        public string firstname_
        {
            get
            {
                return firstname;
            }
            set
            {
                if (firstname == "")
                {
                    Console.WriteLine("Значение не может быть пустым");
                }
            }
        }
        public Person()
        {

        }
        public Person(string name, string surname, string firstname)
        {
            this.name = name;
            this.surname = surname;
            this.firstname = firstname;
        }
        public void ShowPerson()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Владелец карты:");
            Console.ResetColor();
            Console.WriteLine("\nИмя: {0}\nФамилия: {1}\nОтчество: {2}\n", name_, surname_, firstname_);
        }
        
        ~Person()
        {
            Console.WriteLine("Объект разрушен");
        }
    }
    class Program
    {
      static void Main(string[] args)
      {
            Console.OutputEncoding = Encoding.GetEncoding("utf-8");
            Console.Title = "Юмаков Максим - Банкомат";
            CreditScore creditCard = new CreditScore(10);
            creditCard.takeОff(5);
            creditCard.topUp(25);
            creditCard.showScore();
            Console.ReadKey();
            Console.Clear();

            DebetScore debetCard = new DebetScore(15000);
            debetCard.topUp(10000);
            debetCard.takeОff(15000);
            debetCard.showScore();
            Console.ReadKey();
            Console.Clear();

            GoldScore g1 = new GoldScore(100);
            g1.topUp(50);
            g1.takeОff(75);
            g1.showScore();
            Console.ReadKey();
            Console.Clear();

            CreditScore g12 = new CreditScore(50);
            CreditScore g21 = new CreditScore(100);
            if (g12 >= g21 == true)
            {
                Console.WriteLine("Первое значение: {0} ₽\nВторое значение: {1} ₽", g12.score_, g21.score_);
                Console.WriteLine("Первое значение больше или равно второго");
            }
            else if(g12 <= g21 == true)
            {
                Console.WriteLine("Первое значение: {0} ₽\nВторое значение: {1} ₽", g12.score_, g21.score_);
                Console.WriteLine("Первое значение меньше или равно второго");
            }
            Console.ReadKey();
            Console.Clear();

            while(true)
            {
                GoldScore goldScore = new GoldScore(150);
                break;
            }
        }
    }
}
