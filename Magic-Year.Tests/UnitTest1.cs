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
        public void CalcMonthlySalaryFromAnnualSalary()
        { 
          var testMonthly = Program.MonthlySal("60050");
          Assert.Equal("5004", testMonthly);
        }

    }
}
