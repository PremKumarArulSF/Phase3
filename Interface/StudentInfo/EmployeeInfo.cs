using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class EmployeeInfo : IDisplayInfo
    {
//          EmployeeID, Name, FatherName

// Methods: Display

  private static int s_employeeID=200;
  public string EmployeeID{get;}
  public string Name="Arun";
  public string FatherName="Tharun";

   public EmployeeInfo()
   {
    EmployeeID="EID"+(++s_employeeID);
   }
  public void Display()
  {
    System.Console.WriteLine($"EmployeeID : {EmployeeID} Name : {Name}  FatherName :{FatherName}");
  }
    }
}