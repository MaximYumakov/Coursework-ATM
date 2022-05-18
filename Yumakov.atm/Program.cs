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
        protected override void showScore()
        {
            throw new NotImplementedException();
        }

        protected override void takeОff()
        {
            throw new NotImplementedException();
        }

        protected override void topUp()
        {
            throw new NotImplementedException();
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
            Console.WriteLine("Abdula");
            Console.ReadKey();
      }
   }
}
