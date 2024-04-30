using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientDetail
{
    public class DoctorInfo : PatientInfo  //The Sealed class Patient info cannot inherited by another class.
    {
        private static int s_doctorID=100;
        public string DoctorID { get;  }
        public string Name ="Ram";
        public string FatherName="Varun";
        public DoctorInfo()
        {
            DoctorID="DID"+(++s_doctorID);
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"DoctorID{DoctorID} Name{Name} FatherName{FatherName}");
        }
        
        
        
        
        
        
    }
}