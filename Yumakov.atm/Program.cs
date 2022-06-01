using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yumakov.atm
{
   abstract class Score
   {
        protected int score;
        public abstract void showScore(); 
        // Посмотреть баланс
        public abstract void takeОff(int minusMoney); 
        // Снять деньги
        public abstract void topUp(int plusMoney); 
        // Пополнить баланс
        public abstract void transferMoney();
        // Перевести деньги
      // добавить срок действия счёта / карты
   }
    class CreditScore : Score
    {
        Person person = new Person("Юмаков", "Максим", "Владиславович");
        public int score_
        {
            get 
            {
                if (score < 0)
                {
                    Console.WriteLine("У вас баланс меньше 0, пожалуйста, пополните счёт");
                }
                return score;
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
            Person p1 = new Person("Максим", "Юмаков", "Владиславович");
            p1.ShowPerson();
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
        }

        public override void takeОff(int minusMoney)
        {
            score -= minusMoney;
            Console.WriteLine("Снятие прошло успешно");
            Console.WriteLine("Вы сняли {0} ₽", minusMoney);
        }

        public override void topUp(int plusMoney)
        {
            score += plusMoney;
            Console.WriteLine("Пополнение прошло успешно");
            Console.WriteLine("Вы пополнили баланс на {0} ₽", plusMoney);
        }

        public override void transferMoney()
        {
            throw new NotImplementedException();
        }
        ~CreditScore()
        {
            Console.WriteLine("Объект разрушен");
        }
    }
    class DebetScore : Score
    {
        public int score_
        {
            get
            {
                if (score < 0)
                {
                    Console.WriteLine("У вас баланс меньше 0, пожалуйста, пополните счёт");
                }
                return score;
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
            Person p1 = new Person("Максим","Юмаков","Владиславович");
            p1.ShowPerson();
            Console.WriteLine("Ваш баланс: {0} ₽", score_);
        }

        public override void takeОff(int minusMoney)
        {
            score -= minusMoney;
            Console.WriteLine("Снятие прошло успешно");
            Console.WriteLine("Вы сняли {0} ₽", minusMoney);
        }

        public override void topUp(int plusMoney)
        {
            score += plusMoney;
            Console.WriteLine("Пополнение прошло успешно");
            Console.WriteLine("Вы пополнили баланс на {0} ₽", plusMoney);
        }

        public override void transferMoney()
        {
            throw new NotImplementedException();
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
            base.showScore();
        }
        public override void takeОff(int minusMoney)
        {
            base.takeОff(minusMoney);
        }
        public override void topUp(int plusMoney)
        {
            base.topUp(plusMoney);
        }
        public override void transferMoney()
        {
            base.transferMoney();
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
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nОтчество: {2}\n", name_, surname_, firstname_);
        }
        ~Person()
        {
            Console.WriteLine("Объект разрушен");
        }
        //static public bool operator ==(int ob1, int ob2) /// object
        //{
            
        //}

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

            CreditScore creditMax = new CreditScore(25);
            creditMax.takeОff(24);
            creditMax.topUp(100);
            Console.ReadKey();
            Console.Clear();
      }
    }
}
