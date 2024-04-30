using System;
namespace EmployeeSalary;
class Program{
    public static void Main(string[] args)
    {
        ParmanentEmployee parmanent1=new ParmanentEmployee(10000,05,"ParmanentType");
        Console.WriteLine($"The Salary for paramanent employee 1 is {parmanent1.ShowSalary()}");
         ParmanentEmployee parmanent2=new ParmanentEmployee(20000,05,"ParmanentType");
         Console.WriteLine($"The Salary for paramanent employee 2 is {parmanent2.ShowSalary()}");
        TemporaryEmployee temporary1=new TemporaryEmployee(7000,03,"Temporary");
         Console.WriteLine($"The Salary for temporary employee 1 is {temporary1.ShowSalary()}");
         TemporaryEmployee temporary2=new TemporaryEmployee(5000,03,"Temporary");
         Console.WriteLine($"The Salary for temporary employee 2 is {temporary2.ShowSalary()}");
   
    }
}
