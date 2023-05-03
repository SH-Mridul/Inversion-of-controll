using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversionofcontrol
{
    public interface ISalaryCalculator
    {
        void SetHoursAndAmount(double amountPerHour, double workingHours);
        public double GetCalculateSalary();
    }
}
