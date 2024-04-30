using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkSheet
{
    public class TheoryExamMarks : PersonalInfo
    {
        public int[] sem1={89,70,80,90,87,77};
         public int[] sem2={98,60,82,91,82,74};
          public int[] sem3={90,79,81,91,87,77};
           public int[] sem4={87,70,80,90,87};
            
             public TheoryExamMarks(string name,string fatherName,string phone,DateTime dob,string gender): base( name, fatherName, phone, dob, gender)
             {
                
             }

             

    }
}