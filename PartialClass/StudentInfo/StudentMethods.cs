using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public partial class StudentInfo
    {
        int total;
        double percentage;
        public void Calculate()
        {
             total=Physics+Chemistry+Maths;
             percentage=(double)(total*100)/300;
        }
        public void Display()
        {
            System.Console.WriteLine($"Student id :{StudentID}  Name:{Name}");
            System.Console.WriteLine($"Gender:{Gender} Mobile: {Mobile} DOB : {DOB.ToString("dd/MM/yyyy")}");
            System.Console.WriteLine("The Percentage is "+Math.Round(percentage,2));
        }
    }
}