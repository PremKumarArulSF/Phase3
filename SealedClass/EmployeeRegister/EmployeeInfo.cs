using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    public sealed class EmployeeInfo
    {

private static int s_userID=100;
  public string UserID { get;  }
  public string Password { get;set;}
  public int  KeyInfo=100;
  public EmployeeInfo()
  {
    UserID="UID"+(s_userID);
  }
  public void UpdateInfo()

{
    System.Console.WriteLine("Updated from employee");
}  
public void DisplayInfo()
{
    System.Console.WriteLine($"UserID: {UserID} Passwaord: {Password} KeyInfo: {KeyInfo}");
}
  
  
  
  
  


    }
}