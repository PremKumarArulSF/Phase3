using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccount
{
    public class AccountInfo : PersonalInfo
    {
        //         Properties: AccountNumber, BranchName, IFSCCode, Balance

        // Methods: ShowAccountInfo, Deposit , Withdraw, ShowBalance.
        public long AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public int Balance { get; set; }

        public void ShowAccountInfo()
        {
            System.Console.WriteLine($"Name: {Name}  FatherName: {FatherName} DOB: {DOB.ToString("dd/MM/yyyy")} Phone: {PhoneNumber} Gender: {Gender}  MailID: {MailID}");
        }
        public void Deposit()
        {
            System.Console.Write("Enter the deposit amount");
            int depositAmount=int.Parse(Console.ReadLine());
            Balance=Balance+depositAmount;
            System.Console.WriteLine("Updated balance is "+Balance);
        }
        public void Withdraw(){
           System.Console.Write("Enter the withdraw amount: ");
           int withDraw=int.Parse(Console.ReadLine());
            Balance-=withDraw;
            System.Console.WriteLine("Updated balance is "+Balance);
        }
        public void ShowBalance()
        {
            System.Console.WriteLine("The current balance is "+Balance);
        }









    }
}