using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class  EmployeeInfo
    {
        private static int s_employeeID=100;
        public string Name { get; set; }
        public string EmployeeID { get; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        
     
        
    }
}