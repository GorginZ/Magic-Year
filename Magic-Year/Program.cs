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
       Console.WriteLine("please enter your annual salary");
        var annual = Console.ReadLine();
      Console.WriteLine(MonthlySal(annual));
    }

    public static string NameConcat(string firstName, string lastName) => $"{firstName} {lastName}";


     public static string MonthlySal(string annual) 
     {
       int annualInt;
       int monthly;
       var resBool = int.TryParse(annual, out annualInt);

        if (resBool == true)
        {
          
        }
       
      return null; // $"Monthly Salary: {monthly}";
     } 

  }
}
