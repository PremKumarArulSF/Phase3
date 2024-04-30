
using System;
using MarkSheet;
class Program{
    public static void Main(string[] args)
    {
    MarkSheets mark=new MarkSheets("Prem","Arul","909876545",new DateTime(2002,05,22),"male",new DateTime(2023,09,11),98);
    mark.ShowUGMarkSheet();
     MarkSheets mark1=new MarkSheets("Karan","Tharun","909876545",new DateTime(2001,03,21),"male",new DateTime(2022,01,01),90);
    mark1.ShowUGMarkSheet();
    }
}