using System;
namespace HierarchicalInheritance;
class Program{
    public static void Main(string[] args)
    {
         Teacher teacher1=new Teacher("Karun","Varathan",new DateTime(1992,04,23),"9098654323","karun@gmail.com","ECE","Electonic circuit","M.E in Electronic",2,new DateTime(2021,05,22));
         teacher1.ShowDetails();
         Teacher teacher2=new Teacher("Dharsan","Mari",new DateTime(1993,04,23),"9098654903","dhasran@gmail.com","CSE","Fandamental Of C","MCA",2,new DateTime(2020,05,22));
         teacher2.ShowDetails();
         StudentInfo student1 =new StudentInfo("Arun","Tharun",new DateTime(2000,11,02),"9098764512","arun@gmail.com","B.E","ECE",02);
         student1.ShowDetails();
         StudentInfo student2 =new StudentInfo("Mukeash","Iyyapan",new DateTime(2002,02,05),"9098764612","mukeash@gmail.com","B.E","cse",04);
         student2.ShowDetails();
         PrincipalInfo principal1=new PrincipalInfo("Varun","Ganesh",new DateTime(1990,04,23),"9812343355","varun@gmail.com","Phd",3,new DateTime(2020,11,09));
         principal1.ShowDetails();
         PrincipalInfo principal2=new PrincipalInfo("Manish","Gandhi",new DateTime(1993,04,23),"98123433554","mainsh@gmail.com","Phd",1,new DateTime(2021,03,09));
         principal2.ShowDetails();
    }
}
