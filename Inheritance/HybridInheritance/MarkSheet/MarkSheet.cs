using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarkSheet
{
    public class MarkSheets : TheoryExamMarks,ICalculate
    {
        private static int s_markSheetNumber=100;
        public string MarkSheetNumber { get;  }
        public DateTime DateOfIssue { get; set; }
        public int Total { get; set; }
        public int Percentage { get; set; }
        public int ProjectMark{ get; set; }


     public MarkSheets(string name,string fatherName,string phone,DateTime dob,string gender,DateTime dateOfIssue,int projectMark): base(name,fatherName,phone,dob, gender)
     {
         MarkSheetNumber="MID"+(++s_markSheetNumber);
         DateOfIssue =dateOfIssue;
         ProjectMark=projectMark;
     }
       public double CalculateMark(int []a)
       {
          Total=0;
          if(a.Length==5)
          {
            Total+=ProjectMark;
          }
          for(int i=0;i<a.Length;i++)
          {
            Total+=a[i];
          }
          Percentage=(Total*100)/600;
          return Percentage;
       }
        public void  ShowUGMarkSheet()
        {
           double Percentage1=CalculateMark(sem1);
           double Percentage2=CalculateMark(sem2);
           double Percentage3=CalculateMark(sem3);
           double Percentage4=CalculateMark(sem4);
           System.Console.WriteLine($"MarksheetNumber: {MarkSheetNumber} Name: {Name}");
           System.Console.WriteLine($"Sem 1 Mark Percentage is {Math.Round(Percentage1,2)}");
            System.Console.WriteLine($"Sem 1 Mark Percentage is {Math.Round(Percentage2,2)}");
             System.Console.WriteLine($"Sem 1 Mark Percentage is {Math.Round(Percentage3,2)}");
              System.Console.WriteLine($"Sem 1 Mark Percentage is {Math.Round(Percentage4,2)}");
            
        }
  
          
        
        
        
        
        
    }
}