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
        public abstract void showScore(); // Посмотреть баланс
        public abstract void takeОff(int minusMoney); // Снять деньги
        public abstract void topUp(int plusMoney); // Пополнить баланс
        public abstract void transferMoney();// Перевести деньги
      // добавить срок действия счёта / карты
   }
    class CreditScore : Score
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

        }
   }
}
