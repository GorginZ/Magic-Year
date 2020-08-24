using System;
using Xunit;
using Magic_Year;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;



namespace Magic_Year.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void FullName()
    {
      var testFullName = UserInput.NameConcat("Georgia", "Leng");
      Assert.Equal("Georgia Leng", testFullName);
    }

    [Fact]
    public void TestCalcMonthlySalaryFromAnnualSalary()
    {
      var testMonthly = UserInput.MonthlySal("60050");
      Assert.Equal("Monthly Salary: 5004", testMonthly);
    }
    [Fact]
    public void TestCalcMagicYear()
    {
      var testMagicYear = UserInput.CalcMagicYear("1980");
      Assert.Equal("Magic Year: 2045", testMagicYear);
    
    }

   [Fact]
   public void FirstNameAttributeTest()
   {
     //arrange
     var testInput = new UserInput();
     testInput.FirstName = "Ge";
     testInput.LastName = "Last";
     testInput.AnnualSalary = "50000";
     testInput.WorkStartYear = "30000";
//context?
       var context = new ValidationContext(testInput, null, null);
       var result = new List<ValidationResult>();


     // act
  bool IsValid = Validator.TryValidateObject(testInput, context, result, true);
     //Assert
     Assert.False(IsValid);
   }

     [Fact]
   public void ErrorMesssageTest()
   {
     //arrange
     var testInput = new UserInput();
     testInput.FirstName = "Ge";
     testInput.LastName = "Last";
     testInput.AnnualSalary = "50000";
     testInput.WorkStartYear = "30000";
    //context?
       var context = new ValidationContext(testInput, null, null);
       var result = new List<ValidationResult>();
       var message = "";


     // act
  bool IsValid = Validator.TryValidateObject(testInput, context, result, true);

 foreach (var validation in result)
      {
        
        message = (validation.ErrorMessage);
      }
      Console.Read();



    //  Assert
     Assert.Equal("First Name should be more than 2 characters", message);
   }

  }
}
