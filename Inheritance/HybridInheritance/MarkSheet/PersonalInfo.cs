using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkSheet
{
    public class PersonalInfo
    {
       // Properties: RegistationNumber, Name, FatherName, Phone, DOB, Gender

       private static int s_registerNumber=100;
       public string RegistationNumber { get; }
       public string Name { get; set; }
       public string FatherName { get; set; }
       public string Phone { get; set; }
       public DateTime DOB { get; set; }
       public string Gender { get; set; }
       public PersonalInfo(string name,string fatherName,string phone,DateTime dob,string gender)
       {
        RegistationNumber="RID"+(++s_registerNumber);
        Name=name;
        FatherName=fatherName;
        Phone=phone;
        DOB=dob;
        Gender=gender;
       }
       
       
       
       
       
       
       
       
    }
}