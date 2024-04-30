using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalData
{
    public interface IFamilyInfo
    {
//         Properties: FatherName, MotherName, HouseAddress, No.Of.Siblings  

// Method: ShowInfo
 

   string FatherName { get; set; }
    string MotherName { get; set; }
    string HouseAddress { get; set; }
  int NoOfSiblings { get; set; }

   void ShowInfo();
 
 
 
    
   
  
  
    }
}