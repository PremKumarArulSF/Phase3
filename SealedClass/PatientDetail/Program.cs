
using System;
using PatientDetail;
namespace PatientDetails;
class Program
{
    public static void Main(string[] args)
    {
        PatientInfo patient=new PatientInfo();
        DoctorInfo doctor=new DoctorInfo();
        patient.DisplayInfo();
        doctor.DisplayInfo();
     }
}