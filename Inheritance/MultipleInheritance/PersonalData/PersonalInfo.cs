using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalData
{
    public enum MaritalDetails{Select,Married,Single}
    public class PersonalInfo :IShowData
    {
//         Properties: Name, Gender,DOB, phone, mobile, Marital details – Married/single

// Method: ShowInfo

   public string Name { get; set; }
   public string Gender { get; set; }
  public DateTime DOB { get; set; }
  public string Phone { get; set; }
  public MaritalDetails MaritalDetails { get; set; }


  public PersonalInfo (string name,string gender,DateTime dob,string phone,MaritalDetails maritalDetails)
  {
    Name=name;
    Gender=gender;
    DOB=dob;
    Phone=phone;
    MaritalDetails=maritalDetails;
  }
 public  void ShowInfo()
  {
     System.Console.WriteLine($"Name: {Name} \nGender{Gender} \nDOB: {DOB.ToString("dd/MM/yyyy")} \nPhone: {Phone} \nMartialStatus: {MaritalDetails}");
  }
  
  
  
  
     
   
   
   


    }
}