using System;
using System.Text;

class MainClass {
  public static void Main () {
    Console.WriteLine ("Please enter your name:");
    string name = Console.ReadLine();

    Console.WriteLine("Hi " + name + ". How are you doing today?" +  "\n This pgm is a quick drill." + " I hope you like it.");

    string newName = name.ToUpper();

    Console.WriteLine("Your name in uppercase is: " + newName);

    StringBuilder sb = new StringBuilder("\t I'm your favorite C# program. ");

    sb.Append(" Now that we have introductions out of the way, ");

    sb.Append(" I'd like to tell you more about myself.");

    sb.Append(" I was born on 26 Feb 2020,");

    sb.Append(" on a PC running Windows Server 2012.");

    sb.Append(" I could go on all night, but I will stop here.");

    Console.WriteLine(sb);
  }
}