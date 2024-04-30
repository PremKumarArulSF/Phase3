using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public class StudentInfo : IDisplayInfo
    {
//         Properties: StudentID, Name, FatherName, Mobile

// Methods: Display
  private static int s_studentId=300;
  public string  StudentID { get;  }
  public string Name="Prem kumar";
  public string FatherName="Arul";
  public string MobileNumber="9098764532";
  public StudentInfo()
  {
      StudentID="SID"+(++s_studentId);
  }
  public void Display()
  {
    System.Console.WriteLine($"Name: {Name} StudentID : {StudentID}  FatherName:{FatherName}  Mobile: {MobileNumber}");
  }
  
  
  
  
    }
}