using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SalaryCalculation
{
    public class Syncfusion : FreeLancer
    {
//         Field : EmployeeID

// Property: EmployeeID, Worklocation

// Method: Overridden CalculateSalary method that calculate salary by NoOfWorkingDays*500 and 
// Overridden display method that display employees details

    public string  _employeeID;
    private static int s_employeeID=100;
    public string EmployeeID { get{return _employeeID;} }
    public string Worklocation { get; set; }

    public Syncfusion(string name,string fatherName,string gender,string qualification,string role,int noOfWorkingDays,string worklocation):base (name, fatherName, gender,qualification, role, noOfWorkingDays)
    {
        _employeeID="EID"+(++s_employeeID);
        Worklocation=worklocation;
    }

        public override void CalculateSalary()
        {
           // SalaryAmount=base.NoOfWorkingDay*500;
           base.CalculateSalary();
            
        }
        public override void Display()
        {
            System.Console.WriteLine($"Employee ID:{_employeeID}");
            base.Display();
            System.Console.WriteLine($"Location :{Worklocation}");
        }






    }
}