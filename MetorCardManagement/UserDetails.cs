using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace MetorCardManagement
{
    public class UserDetails :PersonalDetails,IBalance
    {

 private int _balance;
  private static int s_cardNumber=1000; //Private static field
  public string CardNumber { get; } //ReadOnly property

  public int Balance { get{return _balance;}  }  //property

/// <summary>
/// The Userdetails paremeterised constructor used to assign  a value to its properties and UserDetails class inherites a <see cref="PersonalDetails"/> and <see cref="IBalance"/>
/// </summary>
/// <param name="userName">UserName property is hold a userName value.</param>
/// <param name="phoneNumber">PhoneNumber property is hold a phoneNumber value.</param>
/// <param name="balance">Balance property is hold a balance value.</param>

  public UserDetails(string userName,string phoneNumber,int balance ) :base(userName,phoneNumber)
  {
    CardNumber="CMRL"+(++s_cardNumber);
      _balance=balance;
  }


/// <summary>
/// The single parameterised constructor used to call when read a userlist.
/// </summary>
/// <param name="user">The paramter user is string datatype.It conatins userdetails full value</param> <summary>
/// 
/// </summary>
 

  public UserDetails(string user) :base()
  {
     string [] value=user.Split(",");
     CardNumber=value[0];
     s_cardNumber=int.Parse(value[0].Remove(0,4));
     UserName=value[1];
     PhoneNumber=value[2];
     _balance=int.Parse(value[3]);
  }

  /// <summary>
  ///   WalletRecharge method used to Recharge a current user balance.
  /// </summary>
  /// <param name="recharge">The recharge parameter used to add balance  </param>
  /// <returns>It returns interger value</returns>
  public int WalletRecharge(int recharge)
  {
          _balance+=recharge;
          return _balance;
  }

  /// <summary>
  /// DeductMethod used to reduce a current user balance.
  /// </summary>
  /// <param name="ticketPrice">The ticketPrice parameter used to reduce a balance.</param>
  /// <returns>It returns a interger value.</returns>
  public int DeductBalance(int ticketPrice)
  {
      _balance-=ticketPrice;
      return _balance;
  }
  
    
  

    }
}