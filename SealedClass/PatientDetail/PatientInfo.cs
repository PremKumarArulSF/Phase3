using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace PatientDetail
{
    public sealed class PatientInfo
    {
//          PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor

// Method: DisplayInfo

private static int s_patientID=100;
 public string PatientID { get;  }
 public string Name ="Arun";
 public string FatherName ="Karun";
 public int BedNo =12;
 public string NativePlace ="Delhi";
 public string AdmittedFor="Fever";
 public PatientInfo()
 {
    PatientID="PID"+(++s_patientID);
 }

public void DisplayInfo()
{
    System.Console.WriteLine($"PatientID{PatientID} Name{Name} FatherName{FatherName} BedNumber{BedNo} NativePlace{NativePlace} AdmittedFor{AdmittedFor}");
} 
 
 
 
 
 
 
 
 
 
 
 
    }
}