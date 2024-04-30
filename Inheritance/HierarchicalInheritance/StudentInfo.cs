using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID=200;
         public string StudentID { get; }
         public string Degree { get; set; }
         public string Department { get; set; }
         public int Semester { get; set; }
         
          public StudentInfo(string name,string fatherName,DateTime dob,string phone,string mail,string degree,string department,int semester):base(name,fatherName, dob,phone,mail)
          {
                StudentID="SID"+(++s_studentID);
                Degree=degree;
                Department=department;
                Semester=semester;
          }
          
          public void ShowDetails()
         {
            System.Console.WriteLine($"StudentID : {StudentID} Name: {Name} FatherName: {FatherName} DOB: {DOB.ToString("dd/MM/yyyy")} Phone: {Phone}  Gender: {Gender} Mail: {Mail}");
            System.Console.WriteLine($"Department : {Department} Degree: {Degree} Semester: {Semester}");
         }
         
         
         
         
         
    }
}