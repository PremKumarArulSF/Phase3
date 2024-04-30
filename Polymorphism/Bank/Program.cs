
using System;
using Bank;
class Program{
    public static void Main(string[] args)
    {
        BankClass bank1=new SBI();
        BankClass bank2=new ICICI();
        BankClass bank3=new HDFC();
        BankClass bank4=new IDBI();
       Console.WriteLine (bank1.GetIntersetInfo());
        Console.WriteLine (bank2.GetIntersetInfo());
        Console.WriteLine (bank3.GetIntersetInfo());
        Console.WriteLine (bank4.GetIntersetInfo());
    }
}