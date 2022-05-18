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
        protected abstract void showScore(); // Посмотреть баланс
        protected abstract void takeОff(); // Снять деньги
        protected abstract void topUp(); // Пополнить баланс
        protected abstract void transferMoney();// Перевести деньги
      // добавить срок действия счёта / карты
   }
    class CreditScore : Score
    {
        public CreditScore()
        {
            score = 0;
        }
        public CreditScore(int score)
        {
            this.score = score;
        }

        protected override void showScore()
        {
            Console.WriteLine(score);
        }

        protected override void takeОff()
        {
            int minusMoney = 50;
            score -= minusMoney;
        }

        protected override void topUp()
        {
            int plusMoney = 50;
            score += plusMoney;
        }

        protected override void transferMoney()
        {
            throw new NotImplementedException();
        }
    }
    class Program
   {
      static void Main(string[] args)
      {
            CreditScore c1 = new CreditScore(50);
            
            Console.ReadKey();
      }
   }
}
