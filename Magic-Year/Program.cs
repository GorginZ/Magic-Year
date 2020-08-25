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
    //class variable accessable for all methods in class

    static void Main(string[] args)
    {
      var testInput = new UserInput();
  

      List<string> inputQuestions = new List<string> { "Please enter your first name: ", "Please enter your Last name: ", "Please enter your annual salary: ", "please enter your work start year: " };

      Console.WriteLine(inputQuestions[0]);
      testInput.FirstName = Console.ReadLine();
      var context = new ValidationContext(testInput);

      ValidateFirstName(testInput, context);


      Console.WriteLine(inputQuestions[1]);
      testInput.LastName = Console.ReadLine();
      Console.WriteLine(inputQuestions[2]);
      testInput.AnnualSalary = Console.ReadLine();
      Console.WriteLine(inputQuestions[3]);
      testInput.WorkStartYear = Console.ReadLine();
      Console.WriteLine($"{testInput.FirstName} {testInput.LastName} {testInput.AnnualSalary} {testInput.WorkStartYear}");


      // pass context object to validator class


      //validation result collection. is passed as third parameter to context

      //output


    }


    public static void ValidateFirstName(UserInput testInput, ValidationContext context)
    {
      context.MemberName = nameof(UserInput.FirstName);

      var result = new List<ValidationResult>();
      var isValidProp = Validator.TryValidateProperty(testInput.FirstName, context, result);
      Console.WriteLine(isValidProp);

      while (!isValidProp)
      {

        foreach (var validation in result)
        {
          Console.WriteLine(validation.ErrorMessage);
        }
        
        Console.WriteLine("Please enter again");

        testInput.FirstName = Console.ReadLine();
        result = new List<ValidationResult>();
        isValidProp = Validator.TryValidateProperty(testInput.FirstName, context, result);
      }

    }

  }
}
