using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInfo
{
    public partial class StudentInfo
    {
        public StudentInfo(string name,string gender,DateTime dob,string mobile,int physics,int chemistry,int maths)
        {
            StudentID="SID"+(++s_studentID);
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=mobile;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;

        }
    }
}