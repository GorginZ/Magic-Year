using System;

namespace Magic_Year
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Welcome to magic year thing!");
      Console.WriteLine("please enter your first name:");
      var firstName = Console.ReadLine();
      Console.WriteLine("Please enter your last name:");
      var lastName = Console.ReadLine();
      Console.WriteLine(NameConcat(firstName, lastName));
      Console.WriteLine("please enter your annual salary:");
      var annual = Console.ReadLine();
      Console.WriteLine(MonthlySal(annual));
      Console.WriteLine("please enter your work start year:");
      var Startyear = Console.ReadLine();
      Console.WriteLine(CalcMagicYear(Startyear));

    }

    public static string NameConcat(string firstName, string lastName) => $"{firstName} {lastName}";


    public static string MonthlySal(string annual)
    {
      int annualInt;
      int monthly;
      var resBool = int.TryParse(annual, out annualInt);

      if (resBool == true)
      {
        monthly = (annualInt / 12);
        return $"Monthly Salary: {monthly}";

      }
      else
      {
        return "Please enter numbers only";
      }
    }

    public static string CalcMagicYear(string startYear)
    {
      int magicYear;
      int startInt;
      var resBool = int.TryParse(startYear, out startInt);

      if (resBool == true)
      {
        magicYear = (startInt + 65);
        return $"Magic Year: {magicYear}";
      }
      else
      {
        return "Please enter numbers only";
      }
    }
  }
}
