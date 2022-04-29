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
      protected abstract string showScore();
      protected abstract int takeОff();
      protected abstract int topUp();
      protected abstract int transferMmoney();
   }
   class Program
   {
      static void Main(string[] args)
      {
      }
   }
}
