using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversionofcontrol
{
    public class Employee
    {
        private string EmployeeName { get; set; }
        private double HourlyRate { get; set; }
        private double WorkingHours { get; set; }

        public ISalaryCalculator _salaryCalculator;
      

        public Employee(string employeeName,double hourlyRate,double workingHours)
        {

            EmployeeName = employeeName;
            HourlyRate = hourlyRate;
            WorkingHours = workingHours;
            _salaryCalculator = SalaryCalculatorFactory.GetSalaryCalculatorObject();
        }


        public double getSalary()
        {
            _salaryCalculator.SetHoursAndAmount(HourlyRate,WorkingHours);
            return _salaryCalculator.GetCalculateSalary();
        }
    }
}
