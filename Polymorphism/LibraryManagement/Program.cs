
using System;
namespace LibraryManagement;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eee=new EEEDepartment();
        eee.SetBookInfo("Keshavan","Electronic Circuit","Sujatha",2019);
        eee.DisplayInfo();
        CSEDepartment cse=new CSEDepartment();
        cse.SetBookInfo("Murali","Fundamental of C","Kumaran",2022);
        cse.DisplayInfo();
        
}
}