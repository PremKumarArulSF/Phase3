using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Salary
{
    public class Attendence
    {
        public int TotalWorkingDays { get; set; }
        public int LeaveTaken { get; set; }
        public int  PermissionTaken { get; set; }
        
        public Attendence(int totalWorkingDays,int leaveTaken,int permissionTaken)
        {
            TotalWorkingDays=totalWorkingDays;
            LeaveTaken=leaveTaken;
            PermissionTaken=permissionTaken;
        }

        public int  CalculateSalary()
        {
           int NoofDayWorked=TotalWorkingDays-LeaveTaken-PermissionTaken;
           return NoofDayWorked*500;
        }
        
        
    }
}