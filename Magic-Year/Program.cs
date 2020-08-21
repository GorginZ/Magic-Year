using System;

namespace Magic_Year
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Welcome to magic year thing!");
      Console.WriteLine("please enter your first name");
      var firstName = Console.ReadLine();
      Console.WriteLine("Please enter your last name");
      var lastName = Console.ReadLine();
      Console.WriteLine(NameConcat(firstName, lastName));
    }

    public static string NameConcat(string firstName, string lastName) => $"{firstName} {lastName}";

  }
}
