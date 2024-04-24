using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class CustomerDetails :PersonalDetails ,IBalance
    {
//         Field: _balance
// Properties: CustomerID, WalletBalance
// Methods: WalletRecharge, DeductBalance

  private int _balance;
  private static int s_customerID=1000;
  public int WalletBalance { get{return _balance;} }
  public string CustomerID { get;  }


 public CustomerDetails(int balance,string name,string fatherName,Gender gender,string mobile,DateTime dob,string mailID,string location):base(name,fatherName,gender,mobile, dob,mailID,location)
 {
   CustomerID="CID"+(++s_customerID);
   _balance=balance;
 }
  public int WalletRecharge(int amount)
  {
     _balance+=amount;
     return _balance;
  }
  public int DeductBalance(int deductAmount)
  {
    _balance-=deductAmount;
    return _balance;
  }
  
    
  

    }
}