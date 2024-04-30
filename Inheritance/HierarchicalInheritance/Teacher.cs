using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class Teacher :PersonalInfo
    { 
        private static int s_teacherID=100;
         public string TeacherID { get;  }
         public string Department { get; set; }
         public string SubjectTeacher { get; set; }
         public string Qualification { get; set; }
         public int  YearOFExperience { get; set; }
         public DateTime DOJ { get; set; }
         
         public Teacher(string name,string fatherName,DateTime dob,string phone,string mail,string department,string subjectTeacher,string qualification,int yearOFExperience,DateTime doj):base(name,fatherName,dob,phone, mail)
         {
                TeacherID="TID"+(++s_teacherID);
                Department=department;
                SubjectTeacher=subjectTeacher;
                Qualification=qualification;
                YearOFExperience=yearOFExperience;
                DOJ=doj;
         }  

         public void ShowDetails()
         {
            System.Console.WriteLine($"Teacher ID : {TeacherID} Name: {Name} FatherName: {FatherName} DOB: {DOB.ToString("dd/MM/yyyy")} Phone: {Phone}  Gender: {Gender} Mail: {Mail}");
            System.Console.WriteLine($"Department : {Department} SubjectTeacher :{SubjectTeacher} Qualification: {Qualification} YearOFExperience: {YearOFExperience} DOJ: {DOJ.ToString("dd/MM/yyyy")}");
         }

         
         
    }
}