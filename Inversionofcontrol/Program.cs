using System;
namespace Inversionofcontrol
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee mridul = new Employee(employeeName:"Mridul",hourlyRate:10,workingHours:30);
            Console.WriteLine(mridul.getSalary());
            Console.ReadLine();
        }
    }
}