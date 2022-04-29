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
      protected abstract string showScore(); // Посмотреть баланс
      protected abstract int takeОff(); // Снять деньги
      protected abstract int topUp(); // Пополнить баланс
      protected abstract int transferMoney();// Перевести деньги
    }
   class Program
   {
      static void Main(string[] args)
      {
      }
   }
}
