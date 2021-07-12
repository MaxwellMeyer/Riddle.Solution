using System;
using System.Collections.Generic;

namespace RiddlesOfTheSphinx.Models
{
  public class Riddles
  {
    public static List<Riddle> theRiddles = new List<Riddle>
    {
      new Riddle("clock".ToLower(), "What has hands and a face, but can’t hold anything or smile?"),
      new Riddle("name".ToLower(), "It belongs to you, but your friends use it more. What is it?"),
      new Riddle("promise".ToLower(), "If you don’t keep me, I’ll break. What am I?"),
      new Riddle("coin".ToLower(), "I have a tail and a head, but no body. What am I?"),


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