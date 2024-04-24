using System;
namespace MetorCardManagement;
class Program{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        //Operations.DefaultDetails();
        FileHandling.ReadFromCSV();
        Operations.Mainmenu();
        FileHandling.WriteToCSV();
       
    }
}