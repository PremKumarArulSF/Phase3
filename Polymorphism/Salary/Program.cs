using System;
using Salary;
class Program{
    public static void Main(string[] args)
    {
        Attendence month1=new Attendence(30,1,2);
        Attendence month2=new Attendence(29,4,0);
        Attendence month3=new Attendence(30,0,0);
        Console.WriteLine(month1.CalculateSalary());
        Console.WriteLine(month2.CalculateSalary());
        Console.WriteLine(month3.CalculateSalary());
        
    }
}
