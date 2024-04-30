using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalInfo
{
    public class PersonalInfo
    {
//         Properties: Name, FatherName, Mobile, Mail, Gender

// Method: virtual Update, DisplayInfo,

   public string Name { get; set; }

  public string FatherName { get; set; }
  public string Mobile { get; set; }
  public string MailID { get; set; }
  public string Gender { get; set; }
  
   public virtual void Update(string name,string fatherName,string mobile,string mailID,string gender)
   {
    Name=name;
    FatherName=fatherName;
    Mobile=mobile;
    MailID=mailID;
    Gender=gender;
   }
   public virtual void  DisplayInfo()
   {
         System.Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nMobile: {Mobile} \nMailID: {MailID} \nGender: {Gender}");
   } 
  
  
  
  
  
     
   
    }
}