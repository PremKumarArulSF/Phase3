using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModel
{
    public class ShiftDezire :Car,IBrand
    {
//         Property:   MakingID(Auto), EngineNumber, ChasisNumber

// Method: Show Details


 private static int s_makingID=100;
  public int EngineNumber { get; set; }
  
  
   public string MakingID { get;  }
   public int ChasisName { get; set; }
   
    public ShiftDezire()
   
   
    }
}