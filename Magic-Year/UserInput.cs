using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Collections.Generic;


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
    
  }



}
  