using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
       // Properties: Name, FatherName, Phone, Mail, DOB, Gender

       public string Name ="Arun";
       public string FatherName ="Karun";
       public string PhoneNumber="9009234567";
       public string MailID ="xyz@gmail.com";
       public DateTime DOB =new DateTime(2002,05,22);
       public Gender Gender =Gender.Male;
       
       
       
       
       
       
       
       
       
       
       
       
    }
}