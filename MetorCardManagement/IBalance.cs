using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetorCardManagement
{
    public interface IBalance
    {


   int Balance{get;} 
   int WalletRecharge(int amount); 
   int DeductBalance(int price);


    }
}