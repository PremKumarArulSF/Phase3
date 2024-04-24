using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class FoodDetails
    {
        //Properties: FoodID, FoodName, PricePerQuantity, QuantityAvailable

        private static int s_foodID=2000;
        public string FoodID { get;  }
        public string FoodName {get;set;}
        public int  PricePerQuantity { get; set; }
        public int QuantityAvailable{get;set;}

        public FoodDetails(string foodName,int pricePerQuantity,int quantityAvailable)
        {
            FoodID="FID"+(++s_foodID);
            FoodName=foodName;
            PricePerQuantity=pricePerQuantity;
            QuantityAvailable=quantityAvailable;
        }
        
        
        
        
    }
}