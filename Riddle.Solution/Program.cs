using System;
using System.Collections.Generic;
using RiddlesOfTheSphinx.Models;

namespace RiddlesOfTheSphinx
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("RIDDLES OF THE SPHINX");
      Console.WriteLine("ANSWER IF YOU DARE...");
      List<Riddle> test = Riddles.theRiddles;
      Console.WriteLine(test[0].Question);
      Console.WriteLine(test[0].Answer);
    }
  }
}
