using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;

namespace PersonalInfo
{
    public class FamilyInfo : PersonalInfo
    {
//         Properties: FatherName, MotherName, NoOfSiblings, NativePlace

// Method: Sealed override Update, DisplayInfo

   public string FatherName { get; set; }
   public string MotherName { get; set; }
   public string NoOfSiblings { get; set; }

  public string NativePlace { get; set; }
    public sealed override void Update(string name,string fatherName,string mobile,string mailID,string gender,string motherName,string noOfSiblings,string nativePlace)
    
        {
            base.Update(name, fatherName, mobile, mailID, gender);
            MotherName=motherName;
            NoOfSiblings=noOfSiblings;
            NativePlace=nativePlace;
        }

        public sealed override void DisplayInfo()
        {
            System.Console.WriteLine($"Name: {Name} \nFatherName: {FatherName} \nMotherName: {MotherName} \nMobile: {Mobile} \nMailID: {MailID} \nGender: {Gender} \nNoOfSiblings: {NoOfSiblings}  \nNativePlace: {NativePlACE}");
        }








    }
}