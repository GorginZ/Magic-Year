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

      List<string> inputQuestions = new List<string> { "Please enter your first name: ", "Please enter your Last name: ", "Please enter your annual salary: ", "please enter your work start year: " };

      var testInput = new UserInput();
      testInput.FirstName = "";
      //context
      var context = new ValidationContext(testInput, null, null);
      var result = new List<ValidationResult>();
      bool IsValid = Validator.TryValidateObject(testInput, context, result, true);

      Console.WriteLine(IsValid);
      //output
      //change x name
      foreach (var x in result)
      {
        Console.WriteLine(x.ErrorMessage);
      }
      Console.Read();

      Console.WriteLine(inputQuestions[0]);
      testInput.FirstName = Console.ReadLine();
      Console.WriteLine(inputQuestions[1]);
      testInput.LastName = Console.ReadLine();
      Console.WriteLine(inputQuestions[2]);
      testInput.AnnualSalary = Console.ReadLine();
      Console.WriteLine(inputQuestions[3]);
      testInput.WorkStartYear = Console.ReadLine();
      Console.WriteLine($"{testInput.FirstName} {testInput.LastName} {testInput.AnnualSalary} {testInput.WorkStartYear}");


      //step 3 pass context object to validator class

    }


  }
}
