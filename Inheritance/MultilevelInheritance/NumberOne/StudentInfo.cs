using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberOne
{
    public class StudentInfo :PersonalInfo
    {


 private static int _registerNumber=100;
 public string RegisterNumber { get; }
 public int Standard { get; set; }
 public string Branch { get; set; }
 public int  AcadamicYear { get; set; }
 
 public StudentInfo(string name, string fatherName, string phoneNumber, string mailID, DateTime dob, string gender,int standard,string branch,int acadamicYear): base(name,fatherName,phoneNumber,mailID,dob,gender)
 {
     RegisterNumber="RID"+(++_registerNumber);
    Standard=standard;
    Branch=branch;
    AcadamicYear=acadamicYear;
 } 

 public StudentInfo(string registerNumber) :base()
 {
    RegisterNumber=registerNumber;
 }
 public void GetStudentInfo() 
 {
     System.Console.WriteLine($"Student Register{RegisterNumber} \nStd {Standard}  \nBranch {Branch} \nAcadamicYear {AcadamicYear}");
 }
 public void ShowInfo()
 {
    System.Console.WriteLine($"The Name is {Name} \nFather name is {FatherName} \nPhone number {PhoneNumber} \nMailId {MailID} \nDOB {DOB.ToString("dd/MM/yyyy")} \nGender {Gender}");
    
 }
 
 
 }
}