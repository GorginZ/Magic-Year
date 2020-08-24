using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Magic_Year
{
  public class UserInput
  {
 [Required(ErrorMessage="First Name Required")]  
       [MaxLength(15,ErrorMessage="First Name should not more than 1`5 character")]  
       [MinLength(2,ErrorMessage="First Name should be more than 2 characters")]   
    public string FirstName { get; set; }


    // [Required, RegularExpression("/^[A-Za-z]+$/")]
[Required(ErrorMessage="Last Name Required")]  
       [MaxLength(15,ErrorMessage="Last Name should not more than 1`5 character")]  
       [MinLength(2,ErrorMessage="Last Name should be more than 2 characters")] 
    public string LastName { get; set; }
    [Required]
    [RegularExpression("^[0-9]+$", ErrorMessage = "Annual Salary must include numbers only")]   
    public string AnnualSalary { get; set; }
    [Required]
    [RegularExpression("^[0-9]+$", ErrorMessage = "Your work start your should only include numbers")]   
    public string WorkStartYear { get; set; }

    public static string NameConcat(string FirstName, string LastName) => $"{FirstName} {LastName}";


    public static string MonthlySal(string annual)
    {
      int annualInt;
      int monthly;
      var resBool = int.TryParse(annual, out annualInt);

      monthly = (annualInt / 12);
      return $"Monthly Salary: {monthly}";
    }

    public static string CalcMagicYear(string startYear)
    {
      int magicYear;
      int startInt;
      var resBool = int.TryParse(startYear, out startInt);
      magicYear = (startInt + 65);
      return $"Magic Year: {magicYear}";
    }
  }
}
