using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversionofcontrol
{
    public class SalaryCalculator:ISalaryCalculator
    {
        private double AmountPerHour { get; set; }
        private double WorkingHours { get; set; }

        public SalaryCalculator(){}

        public void SetHoursAndAmount(double amountPerHour,double workingHours)
        {
            AmountPerHour = amountPerHour;
            WorkingHours = workingHours;
        }

        public double GetCalculateSalary()
        {
            return AmountPerHour * WorkingHours;
        }
    }
}
