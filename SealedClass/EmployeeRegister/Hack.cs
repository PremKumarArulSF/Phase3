using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister
{
    public class Hack : EmployeeInfo //The class with sealed keyword, that is called sealed class. It cannot inherited by another class but sealed class can inherit a another class
    {
        public int StoreUserID { get;set; }
        public string StorePassword { get; set; }
        public void ShowKeyInfo()
        {
            System.Console.WriteLine("KeyInfo "+KeyInfo);
        }
        public void GetUserInfo(int storeUserID,string storePassword )
        {
          StoreUserID=storeUserID;
          StorePassword=storePassword;
   

        }
        public void ShowuserInfo()
        {
            System.Console.WriteLine($"Name{Name} FatherName{FatherName} Mobile{Mobile} MailID{Mail} Gender{Gender}");
        }
    
    

        
        
        
        
    }
}