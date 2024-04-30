using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeSalary
{
    public class TemporaryEmployee :SalaryInfo
    {
        private static int s_employeeID=1000;
 public string EmployeeID { get; }
 public string EmployeeType { get; set; }
  
  public double DA{get;set;}
  public double HRA{get;set;}
  public double PF { get; set; }

  public double TotalSalary { get; set; }
  public TemporaryEmployee(int basicSalary,int month,string employeeType):base(basicSalary,month)
  {
    EmployeeID="EID"+(++s_employeeID);
    EmployeeType=employeeType;
  }
  public double CalculateSalary()
  {
    DA=(BasicSalary*0.15)/100;
    HRA=(BasicSalary*0.13)/100;
    PF=(BasicSalary*0.1)/100;
    TotalSalary=DA+HRA-PF+BasicSalary;
    return TotalSalary;
  }

  public double  ShowSalary()
  {
       double Salary=CalculateSalary();
       return Math.Round(Salary,2);
  }


    }
}