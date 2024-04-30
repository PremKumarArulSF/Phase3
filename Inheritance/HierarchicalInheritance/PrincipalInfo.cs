using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_principalId=300;
        public string PrincipalID { get;  }
        public string Qualification { get; set; }
        public int YearOFExperience { get; set; }
        public DateTime DOJ { get; set; }

        public PrincipalInfo(string name,string fatherName,DateTime dob,string phone,string mail,string qualification,int yearOFExperience,DateTime doj):base(name,fatherName,dob,phone,mail)
        {
           PrincipalID="PID"+(++s_principalId);
           Qualification=qualification;
           YearOFExperience=yearOFExperience;
           DOJ=doj;
        }

        public void ShowDetails()
        {
            System.Console.WriteLine($"PrincipalID: {PrincipalID}  Name: {Name} FatherName: {FatherName} DOB: {DOB} Phone: {Phone} Gender: {Gender} Maild {Mail}");
            System.Console.WriteLine($"Qualification: {Qualification} YearOFExperience: {YearOFExperience}  DOJ: {DOJ.ToString("dd/MM/yyyy")}");
        }
        
        
        
        
        
        
        
        
    }
}