using SW.PayRool;

namespace SW.Payroll.Tests
{
    public class SalarySlipProcessorTests
    {
        //[Fact]
        //public void Method_Scenario_Outcome()
        //{

        //}
        [Fact]
        public void CalculateBasicSalary_ForEmployeeObject_ReturnsBasicSalary()
        {
            //AAA 

            // Arrange 
            var employee = new Employee { Wage = 500m, WorkingDays = 20 };

            //Act 
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateBasicSalary(employee);
            var expected = 10000m;
            //Assert
            Assert.Equal(actual, expected);
        }
      

    }
}
