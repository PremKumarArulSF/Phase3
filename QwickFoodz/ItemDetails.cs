using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class ItemDetails
    {
        //Properties: ItemID – (ITID100), OrderID, FoodID, PurchaseCount, PriceOfOrder

       private static int s_itemID=4000;
        public string ItemID { get;  }
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public int  PurchaseCount { get; set; }
        public int  PriceOfOrder { get; set; }

        public ItemDetails(string orderID,string foodID,int purchaseCount,int priceOfOrder)
        {
            ItemID="ITID"+(++s_itemID);
            OrderID=orderID;
            FoodID=foodID;
            PurchaseCount=purchaseCount;
            PriceOfOrder=priceOfOrder;
        }
        
        
        
        
        
        
        
        
        
        
    }
}