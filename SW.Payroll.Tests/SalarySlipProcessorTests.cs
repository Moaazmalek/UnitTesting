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
        [Fact]
        public void CalculateBasicSalary_ForEmployeeIsNull_ThrowArgumentNullException()
        {
            //AAA 

            // Arrange 
            Employee employee = null;

            //Act 
            var salarySlipProcessor = new SalarySlipProcessor(null);

            Func<Employee, decimal> func = (e) => salarySlipProcessor.CalculateBasicSalary(employee);
            //Assert
            Assert.Throws<ArgumentNullException>(() => func(employee));
        }
        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeIsNull_ThrowArgumentNullException()
        {
            //AAA 

            // Arrange 
            Employee employee = null;

            //Act 
            var salarySlipProcessor = new SalarySlipProcessor(null);

            Func<Employee, decimal> func = (e) => salarySlipProcessor.CalculateTransportationAllowece(employee);
            //Assert
            Assert.Throws<ArgumentNullException>(() => func(employee));
        }
        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeWorkInOffice_ReturnsTransportationAllowece()
        {
            //AAA 

            // Arrange 
            var employee = new Employee { WorkPlatform = WorkPlatform.Office };

            //Act 
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateTransportationAllowece(employee);
            var expected = Constants.TransportationAllowanceAmount;
            // Assert
            Assert.Equal(actual, expected);

        }
        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeWorkRemote_ReturnsTransportationAllowece()
        {
            //AAA 

            // Arrange 
            var employee = new Employee { WorkPlatform = WorkPlatform.Remote };

            //Act 
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateTransportationAllowece(employee);
            var expected = 0m;
            // Assert
            Assert.Equal(actual, expected);

        }
        [Fact]
        public void CalculateTransportationAllowece_ForEmployeeWorkHybridMode_ReturnsTransportationAllowece()
        {
            //AAA 

            // Arrange 
            var employee = new Employee { WorkPlatform = WorkPlatform.Hybrid };

            //Act 
            var salarySlipProcessor = new SalarySlipProcessor(null);

            var actual = salarySlipProcessor.CalculateTransportationAllowece(employee);
            var expected = Constants.TransportationAllowanceAmount / 2;
            // Assert
            Assert.Equal(actual, expected);

        }

      


    }
}
