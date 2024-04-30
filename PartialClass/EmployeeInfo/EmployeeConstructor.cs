using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInfo
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string name,string gender,string mobile,DateTime dob)
        {
            EmployeeID="EID"+(++s_employeeID);
            Name=name;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
        } 
    }
}