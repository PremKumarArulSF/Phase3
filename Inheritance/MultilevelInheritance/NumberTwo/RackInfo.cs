using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberTwo
{
    public class RackInfo :DepartmentDetails
    {
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }
       // public string DepartmentName ="ECE";

        
        

        public RackInfo(int rackNumber,int columnNumber)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
        
        
        
    }
}