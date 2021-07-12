using System;
using System.Collections.Generic;

namespace RiddlesOfTheSphinx
{
  public class Riddles
  {
    private static List<Riddle> theRiddles = new List<Riddle>
    {
      new Riddle("clock".ToLower(), "What has hands and a face, but can’t hold anything or smile?"),


    };


  }
}

// static void AddContact()
// {
//   Console.WriteLine("NEW CONTACT");
//   Console.WriteLine("Enter a new contact name");
//   string name = Console.ReadLine();
//   Console.WriteLine("Enter a new contact phone number");
//   string number = Console.ReadLine();
//   if (phoneNumbers.ContainsKey(name))
//   {
//     Console.WriteLine("That person is already in your phonebook. Their number is " + phoneNumbers[name]);
//   }
//   else
//   {
//     phoneNumbers.Add(name, number);
//   }
//   Main();
// }