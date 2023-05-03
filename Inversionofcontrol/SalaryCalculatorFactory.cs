using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversionofcontrol
{
    public class SalaryCalculatorFactory
    {
        public static ISalaryCalculator GetSalaryCalculatorObject()
        {
            return new  SalaryCalculator();
        }
    }
}
