// See https://aka.ms/new-console-template for more information
using _4_CSharpLanguageBasic;

Console.WriteLine("Hello, World!");

// boxing and unboxing 
int i = 1;
object o = i + 2; // boxing  
int j = (int)o; // unboxing 
Console.WriteLine("i = {0}", i);
Console.WriteLine("o = {0}", o);
Console.WriteLine("j = {0}", j);

// Create instance of value types and reference types
Company company = new Company("One_Company", 5);  
Employee employee = new Employee(company, "John Doe", 3220);

// Using static methods
string CompanyAddress =  Employee.GetCompanyAddress();
int CompanyRating = Employee.GetCompanyRating();
Console.WriteLine("Address is {0}, and rating is {1}", CompanyAddress, CompanyRating);

// Write a method for each type of parameter modifier
        // by value
double coeficientForBonus = 1.2;
decimal SalaryWithBonus = employee.CalculateSalaryBonus(coeficientForBonus);
Console.WriteLine($"Salary for {employee.Name} with bonus is {SalaryWithBonus}");

// Passed by reference - going in  
decimal empSalary = employee.Salary;
Console.WriteLine($"employeeSalary before is {empSalary}, and Company Rating before is {company._rating}");

employee.InfoCombine(ref empSalary, ref company);

Console.WriteLine($"employeeSalary after is {empSalary}, and Company Rating after is {company._rating}");

//   Passed by reference - going out

decimal newSalary;
Company newCompany;
employee.InfoAssign(out newSalary, out newCompany);
Console.WriteLine($"newSalary after out is {newSalary},  Company Rating after out is {newCompany._rating}, and the new " +
    $"Company Name is {newCompany._name}");

// Static Constructor done in Employee class

// Thread

Thread a = new Thread(new ThreadStart(Employee.Thread_One_Example));
Thread b = new Thread(new ThreadStart(Employee.Thread_Two_Example));
a.Start();
b.Start();