using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;

namespace Magic_Year
{
  public class Program
  {
  
    static void Main(string[] args)
    { 
   
      List<string> inputQuestions = new List<string>{ "Please enter your first name: ", "Please enter your Last name: ", "Please enter your annual salary: ", "please enter your work start year: " };
      
      // foreach (string element in inputQuestions){
      //   Console.WriteLine(element);
      // }

        try {
        //Parse the row here and create the object. don't do any validation here
        var userInstance = UserInput("test", "test", "test", "test");  
        empList.Add(employee);
    }
    catch (ValidationException ve){
        //do whatever
    }

   }

   
           // NameConcat(firstName,lastName);




  
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
        throw new Exception("Annual Salary Should only include digits, eg: 60000");
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
        throw new Exception("Start Year Should only include digits, eg: 1980");
      }

    }
  }
}
