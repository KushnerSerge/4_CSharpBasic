using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_CSharpLanguageBasic
{
    public class Employee
    {
        protected static readonly DateTime globalStartTime;
        public static Company Company { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        // static Constructor
        static Employee()
        {
            globalStartTime = DateTime.Now;

            // The following statement produces the first line of output,
            // and the line occurs only once.
            Console.WriteLine("Static constructor sets global start time to {0}",
                globalStartTime.ToLongTimeString());
        }

        public Employee(Company company, string name, decimal salary)
        {
            Company = company;
            Name = name;
            Salary = salary;
        }
        // Passed by Value
        public decimal CalculateSalaryBonus(double bonusCoeficient)
        {
            return Salary * (decimal)bonusCoeficient;
        }

        // Passed by reference - going in
        public void InfoCombine(ref decimal empSalary, ref Company e_company)
        {
            empSalary = Salary + empSalary;
            e_company._rating += Company._rating;
        }

        // Passed by reference - going out
        public  void InfoAssign(out decimal empSalary, out Company e_company)
        {
            empSalary = Salary;
            e_company._rating = Company._rating * 2;
            e_company._name = Company._name + "_NEW";
        }

        public static int GetCompanyRating()
        {
            return Company._rating;
        }
        public static string GetCompanyAddress()
        {
            return Company._name;
        }
        // Thread Example
        public static void Thread_One_Example()
        {
            for(int i = 0; i <= 7; i++)
            {
                Console.WriteLine("Thread 1 with value: {0}", i);
            }

        }

        public static void Thread_Two_Example()
        {
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine("Thread 2 with value: {0}", i);
            }

        }
    }
    public struct Company
    {
        public string _name;
        public int _rating;

        public Company(string name, int rating)
        {
            this._name = name;
            this._rating = rating;
        }
        
        public static string GetCompanyInfo()
        {
            return "Info contact here";
        }

        public string GetCompanyName()
        {
            return _name;
        }
        public int GetCoompanyRating()
        {
            return _rating;
        }
    }
}
