using System;
using System.Globalization;
namespace NumberOne;
class Program{
    public static void Main(string[] args)
    {
         PersonalInfo person=new PersonalInfo("Arun","Tharun","9090897654","abc@gmail.com",new DateTime(2023,09,11),"Male");
         StudentInfo student=new StudentInfo(person.Name,person.FatherName,person.PhoneNumber,person.MailID,person.DOB,person.Gender,11,"Computer",2023);
         HSCDetails hsc=new HSCDetails(student.RegisterNumber,97,87);
         student.GetStudentInfo();
         student.ShowInfo();
         hsc.GetMark();
         System.Console.WriteLine("The Percentage mark is "+hsc.Calculate());
         hsc.ShowMarkSheet();

    }
}
