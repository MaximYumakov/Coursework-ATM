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
        }

        public override void topUp(int plusMoney)
        {
            score += plusMoney;
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
    class Program
   {
      static void Main(string[] args)
      {
            Console.OutputEncoding = Encoding.GetEncoding("utf-8");
            Console.Title = "Юмаков Максим - Банкомат";
            CreditScore cs1 = new CreditScore(10);
            cs1.takeОff(25);
            cs1.takeОff(25);
            cs1.showScore();
            Console.ReadKey();
            cs1.topUp(100);
            cs1.showScore();
            Console.ReadKey();
      }
   }
}
