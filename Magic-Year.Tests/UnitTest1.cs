using System;
using Xunit;
using Magic_Year;

namespace Magic_Year.Tests
{
  public class UnitTest1
  {
    [Fact]
    public void FullName()
    {
      var testFullName = Program.NameConcat("Georgia", "Leng");
      Assert.Equal("Georgia Leng", testFullName);
    }

    [Fact]
    public void TestCalcMonthlySalaryFromAnnualSalary()
    {
      var testMonthly = Program.MonthlySal("60050");
      Assert.Equal("Monthly Salary: 5004", testMonthly);
    }
    [Fact]
    public void TestCalcMagicYear()
    {
      var testMagicYear = Program.CalcMagicYear("1980");
      Assert.Equal("Magic Year: 2045", testMagicYear);
    }
    [Fact]
    public void TestCalcMagicYearInputType()
    {
      Assert.Throws(typeof(Exception), () => Program.CalcMagicYear("aa29"));
    }

    [Fact]
    public void TestSalaryMagicYearInputType()
    {
      Assert.Throws(typeof(Exception), () => Program.MonthlySal("aa29"));
    }
  }
}
