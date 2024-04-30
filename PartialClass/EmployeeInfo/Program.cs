using System;
namespace EmployeeInfo;
class Program{
    public static void Main(string[] args)
    {
        EmployeeInfo employee=new EmployeeInfo("Prem kumar","Male","9090874563",new DateTime(2002,05,22));
        employee.Update();
        employee.Display();

    }
}
