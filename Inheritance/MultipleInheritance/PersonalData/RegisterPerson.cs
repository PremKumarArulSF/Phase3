using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalData
{
    public class RegisterPerson : PersonalInfo,IShowData,IFamilyInfo
    {
          private static  int s_registerNumber=1000;
        
        public DateTime DateOfRegistration { get; set; }
        
        
         public string RegisterNumber { get;  }
         public string FatherName { get; set; }
         public string MotherName { get; set; }
   public string HouseAddress { get; set; }
   public int NoOfSiblings { get; set; }

    public RegisterPerson(string name,string gender,DateTime dob,string phone,MaritalDetails maritalDetails,DateTime dateOfRegistration): base( name, gender, dob, phone, maritalDetails)
    {
       RegisterNumber="RID"+(++s_registerNumber);
       DateOfRegistration=dateOfRegistration;
    }
    public void ShowInFo()
    {
        System.Console.WriteLine("Registration Number is "+RegisterNumber);
        base.ShowInfo();
       System.Console.WriteLine("DateOFRegistration"+DateOfRegistration.ToString("dd/MM/yyyy"));
    }
   
   
   
            
         
         
         
         
         
    }
}