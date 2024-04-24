using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public interface IBalance
    {
//         Properties: WalletBalance
// Method: WalletRecharge, DeductBalance

  int WalletBalance{get;}
  int WalletRecharge(int balance);
  int DeductBalance(int amount);


    }
}