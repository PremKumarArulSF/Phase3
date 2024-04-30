using System;
namespace BankAccount;
class Program{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo();
        AccountInfo account=new AccountInfo();
        account.AccountNumber=333580001234;
        account.BranchName="ECR Road branch";
        account.IFSCCode="HDFC00123";
        account.Balance=500;
        account.ShowAccountInfo();
        account.Deposit();
        account.Withdraw();
        account.ShowBalance(); 

    }
}
