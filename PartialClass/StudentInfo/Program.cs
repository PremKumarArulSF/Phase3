using System;
namespace StudentInfo;
class Program{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo("Prem kumar","Male",new DateTime(2002,05,22),"9089876543",70,70,90);
        student.Calculate();
        student.Display();
    }
}
