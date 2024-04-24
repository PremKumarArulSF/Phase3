using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        //Properties: OrderID, CustomerID, TotalPrice, DateOfOrder, OrderStatus – {Default, Initiated, Ordered, Cancelled}.

      private static int s_orderID=3000;
        public string OrderID { get;  }

        public string CustomerID { get; set; }
        public int TotalPrice { get; set; }
        public DateTime DateOfOrder { get; set; }
        public OrderStatus OrderStatus { get; set; }
        
        public OrderDetails(string customerID,int totalPrice,DateTime dateOfOrder,OrderStatus orderStatus)
        {
            OrderID="OID"+(++s_orderID);
            CustomerID=customerID;
            TotalPrice=totalPrice;
            DateOfOrder=dateOfOrder;
            OrderStatus=orderStatus;
        }
        
        
        
        
        
        
        
        
    }
}