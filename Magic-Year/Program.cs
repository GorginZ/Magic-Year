using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Magic_Year
{
  public class Program
  {

    static void Main(string[] args)
    {
      var testInput = new UserInput();


      List<string> inputQuestions = new List<string> { "Please enter your first name: ", "Please enter your Last name: ", "Please enter your annual salary: ", "please enter your work start year: " };
      var context = new ValidationContext(testInput);

      Console.WriteLine(inputQuestions[0]);
      testInput.FirstName = Console.ReadLine();
      testInput.FirstName = Validate(testInput.FirstName, "FirstName", context);


      Console.WriteLine(inputQuestions[1]);
      testInput.LastName = Console.ReadLine();
      testInput.LastName = Validate(testInput.LastName, "LastName", context);


      Console.WriteLine(inputQuestions[2]);
      testInput.AnnualSalary = Console.ReadLine();
      testInput.AnnualSalary = Validate(testInput.AnnualSalary, "AnnualSalary", context);

      Console.WriteLine(inputQuestions[3]);
      testInput.WorkStartYear = Console.ReadLine();
      testInput.WorkStartYear = Validate(testInput.WorkStartYear, "WorkStartYear", context);

      // Console.WriteLine($"{testInput.FirstName} {testInput.LastName} {testInput.AnnualSalary} {testInput.WorkStartYear}");
    }

    public static string Validate(string value, string propertyName, ValidationContext context)
    {
      context.MemberName = propertyName;

      var result = new List<ValidationResult>();
      var isValidProp = Validator.TryValidateProperty(value, context, result);
      Console.WriteLine(isValidProp);

      while (!isValidProp)
      {

        foreach (var validation in result)
        {
          Console.WriteLine(validation.ErrorMessage);
        }

        Console.WriteLine("Please enter again");

        value = Console.ReadLine();
        result = new List<ValidationResult>();
        isValidProp = Validator.TryValidateProperty(value, context, result);
      }
      return value;
    }
  }
}
