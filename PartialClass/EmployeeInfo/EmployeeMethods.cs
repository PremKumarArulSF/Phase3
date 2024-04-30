using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeInfo
    {
        public void Update()
        {
            System.Console.WriteLine("This is Update Method");
        }
        public void Display()
        {
            System.Console.WriteLine($"The Student ID: {EmployeeID} and Student Name : {Name}");
            System.Console.WriteLine($"Gender: {Gender}   Mobile: {Mobile}   DOB: {DOB.ToString("dd/MM/yyyy")}");
        }
    }
}