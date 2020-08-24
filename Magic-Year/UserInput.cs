using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Magic_Year
{
  public class UserInput
  {
      [Required, RegularExpression("/^[A-Za-z]+$/")]

      public string FirstName { get; set; }


       [Required, RegularExpression("/^[A-Za-z]+$/")]
     
      public string LastName { get; set; }
    [Required]
      public string AnnualSalary { get; set; }
      [Required]
      public decimal WorkStartYear { get; set; }
       
      public static string NameConcat(string FirstName, string LastName) => $"{FirstName} {LastName}";

      
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
  