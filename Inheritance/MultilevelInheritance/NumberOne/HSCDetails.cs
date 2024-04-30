using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberOne
{
    public class HSCDetails : StudentInfo
    {


 private static int _hscMarkSheetNumber=200;
  public  string HSCMarksheetNumber { get;}
  public int Physics { get; set; }
  public int Chemistry { get; set; }
  public int Total { get; set; } 
  public double PercentageMark { get; set; }
   public HSCDetails(string registerNumber,int physics,int chemistry) :base(registerNumber)

   {

     HSCMarksheetNumber="HSC"+(++_hscMarkSheetNumber);
      Physics=physics;
      Chemistry=chemistry;
   } 
   public void GetMark()
   {
        System.Console.WriteLine($"Physics: {Physics} Chemistry {Chemistry}");
   }
   public double Calculate()
{
     Total=Physics+Chemistry;
     PercentageMark=(Total*100)/200;
     return Math.Round(PercentageMark,2);
}  

public void ShowMarkSheet()
{
    System.Console.WriteLine($"The RegisterNumber is {RegisterNumber} \nThe MarkSheet is {HSCMarksheetNumber}  ");
}
    }
}