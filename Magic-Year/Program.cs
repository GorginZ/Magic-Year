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
      var context = new ValidationContext(testInput, null, null);



      List<string> inputQuestions = new List<string> { "Please enter your first name: ", "Please enter your Last name: ", "Please enter your annual salary: ", "please enter your work start year: " };

   

      Console.WriteLine(inputQuestions[0]);
      testInput.FirstName = Console.ReadLine();

  
      Console.WriteLine(inputQuestions[1]);
      testInput.LastName = Console.ReadLine();
      Console.WriteLine(inputQuestions[2]);
      testInput.AnnualSalary = Console.ReadLine();
      Console.WriteLine(inputQuestions[3]);
      testInput.WorkStartYear = Console.ReadLine();
      Console.WriteLine($"{testInput.FirstName} {testInput.LastName} {testInput.AnnualSalary} {testInput.WorkStartYear}");


      // pass context object to validator class


      //validation result collection. is passed as third parameter to context
      var result = new List<ValidationResult>();
      bool IsValid = Validator.TryValidateObject(testInput, context, result, true);

      Console.WriteLine(IsValid);
      //output
      //change x name
      foreach (var validation in result)
      {
        Console.WriteLine(validation.ErrorMessage);
      }
      Console.Read();
    }


  }
}
