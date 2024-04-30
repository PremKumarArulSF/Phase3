using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace PersonalInfo
{
    public class EmployeeInfo :FamilyInfo
    {
         private static int s_employeeID=100;
         public string EmployeeID { get;}
         public DateTime  DOJ { get; set; }



        //Cannot override a Update class because its sealed
        public override void Update(string name, string fatherName, string mobile, string mailID, string gender,string motherName,string noOfSiblings,string nativePlace,DateTime doj)
        {
            base.Update(name, fatherName, mobile, mailID, gender,motherName,noOfSiblings,nativePlace);
            EmployeeID="EID"+(++s_employeeID);
            DOJ=doj;

        }
        //Cannot override a DisplayInfo because its sealed
        public override void DisplayInfo()
        {
           System.Console.WriteLine($"EmployeeID: {EmployeeID} \n Name: {Name}"); 
        }




    }
}