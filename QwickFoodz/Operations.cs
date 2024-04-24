using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace QwickFoodz
{
  public static class Operations
  {
    static CustomerDetails currentUser;
    static FoodDetails currentFoodUser;
    static ItemDetails currentItemUser;
    static OrderDetails currentOrderUser;
    static List<CustomerDetails> customerList = new List<CustomerDetails>();
    static List<FoodDetails> foodList = new List<FoodDetails>();
    static List<OrderDetails> orderList = new List<OrderDetails>();
    static List<ItemDetails> itemList = new List<ItemDetails>();

    public static void MainMenu()
    {
      string mainChoice = "yes";
      do
      {
        System.Console.WriteLine("MainMenu   \n1.Registration \n2.Login \n3.Exit");
        int mainOption = int.Parse(Console.ReadLine());
        switch (mainOption)
        {
          case 1:
            {
              System.Console.WriteLine("***Customer Registration***");
              Registration();
              break;
            }
          case 2:
            {
              System.Console.WriteLine("***Customer Login***");
              Login();
              break;
            }
          case 3:
            {
              mainChoice = "no";
              System.Console.WriteLine("Exit from MainMenu");
              break;
            }
        }
      } while (mainChoice == "yes");
    }

    public static void Registration()
    {
      System.Console.Write("Enter the name: ");
      string name = Console.ReadLine();
      System.Console.Write("Enter the FatherName:  ");
      string fatherName = Console.ReadLine();
      System.Console.Write("Enter the gender (male/female)");
      Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
      System.Console.Write("Enter the Mobile number: ");
      string mobile = Console.ReadLine();
      System.Console.Write("Enter the  DOB as specified DD/MM/YYYY: ");
      DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
      System.Console.Write("Enter the mail id: ");
      string mailID = Console.ReadLine();
      System.Console.Write("Enter the Location: ");
      string location = Console.ReadLine();
      System.Console.Write("Enter the balance: ");
      int balance = int.Parse(Console.ReadLine());
      CustomerDetails customer = new CustomerDetails(balance, name, fatherName, gender, mobile, dob, mailID, location);
      System.Console.WriteLine("Customer Registration Successfull and CustomerID is " + customer.CustomerID);
      customerList.Add(customer);
    }

    public static void Login()
    {
      System.Console.WriteLine("Enter the customerId to login:");
      string userLogin = Console.ReadLine().ToUpper();
      bool flag = true;
      foreach (CustomerDetails customer in customerList)
      {
        if (customer.CustomerID.Equals(userLogin))
        {
          flag = false;
          currentUser = customer;
          System.Console.WriteLine($"Welcome {customer.Name} to Login..");
          SubMenu();
          break;
        }
      }
      if (flag)
      {
        System.Console.WriteLine("Invalid UserID");
      }

    }

    public static void SubMenu()
    {
      string subChoice = "yes";
      do
      {
        System.Console.WriteLine("SubMenu \n1.Show Profile \n2.Order Food \n3.Cancel Order \n4.Modify Order \n5.Order Histroy \n6.Recharge Wallet \n7.Show Wallet balance \n8.Exit");
        int subOption = int.Parse(Console.ReadLine());
        switch (subOption)
        {
          case 1:
            {
              System.Console.WriteLine("-----Show Profile-----");
              ShowProfile();
              break;
            }
          case 2:
            {
              System.Console.WriteLine("----Order Food---");
              OrderFood();
              break;
            }
          case 3:
            {
              System.Console.WriteLine("---Cancel order---");
              CancelOrder();
              break;
            }
          case 4:
            {
              System.Console.WriteLine("----Modify order----");
              break;
            }
          case 5:
            {
              System.Console.WriteLine("---Order Histroy");
              OrderHistroy();
              break;
            }
          case 6:
            {
              System.Console.WriteLine("------Recharge Wallet----");
              RechargeWallet();
              break;
            }
          case 7:
            {
              System.Console.WriteLine("---Show Wallet balance---");
              ShowWalletBalance();
              break;

            }
          case 8:
            {
              subChoice = "no";
              System.Console.WriteLine("Exit from submenu taking back to main menu");
              break;
            }
        }
      } while (subChoice == "yes");
    }

    public static void ShowProfile()
    {
      System.Console.WriteLine("CustomerID	WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID	Location");


      System.Console.WriteLine($"{currentUser.CustomerID} | {currentUser.WalletBalance} | {currentUser.Name} | {currentUser.FatherName} | {currentUser.Gender} | {currentUser.Mobile} |{currentUser.DOB.ToString("dd/MM/yyyy")} | {currentUser.MailID} | {currentUser.Location}");

    }


    public static void CancelOrder()
    {
      System.Console.WriteLine("OrderID	CustomerID	TotalPrice	DateOfOrder	OrderStatus");
      foreach (OrderDetails order in orderList)
      {
        if (order.CustomerID.Equals(currentUser.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
        {
          System.Console.WriteLine($"{order.OrderID} | {order.CustomerID} | {order.TotalPrice} | {order.DateOfOrder.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
        }
      }
      System.Console.Write("Enter the OrderId to be cancelled: ");
      string userCheckId = Console.ReadLine().ToUpper();
      bool flag = true;
      foreach (OrderDetails order in orderList)
      {
        if (order.OrderID.Equals(userCheckId))
        {
          order.OrderStatus = OrderStatus.Cancelled;
          currentUser.WalletRecharge(order.TotalPrice);

        }
      }
      if (flag)
      {
        System.Console.WriteLine("Invalid OrderId...");
      }

    }

    public static void ModifyOrder()
    {
      System.Console.WriteLine("OrderID	CustomerID	TotalPrice	DateOfOrder	OrderStatus");
      foreach (OrderDetails order in orderList)
      {
        if (order.CustomerID.Equals(currentUser.CustomerID) && order.OrderStatus == OrderStatus.Ordered)
        {
          System.Console.WriteLine($"{order.OrderID} | {order.CustomerID} | {order.TotalPrice} | {order.DateOfOrder.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
        }
      }
      System.Console.Write("Enter the OrderID to modify: ");
      string modifyOrderId = Console.ReadLine().ToUpper();
      //bool flag = true;
      foreach (OrderDetails order in orderList)
      {
        if (order.OrderID.Equals(modifyOrderId) && order.OrderStatus == OrderStatus.Ordered)
        {
          currentOrderUser=order;
          foreach (ItemDetails item in itemList)
          {
            if (item.OrderID.Equals(order.OrderID))
            {
              currentItemUser=item;
              System.Console.WriteLine($"{item.ItemID} | {item.OrderID} | {item.FoodID} | {item.PurchaseCount} | {item.PriceOfOrder}");

            }
          }

        }
      }
      System.Console.Write("Enter the ItemID: ");
      string userItemID = Console.ReadLine().ToUpper();
      foreach(ItemDetails item in itemList)
      {
         if(item.ItemID.Equals(userItemID))
         {
            System.Console.Write("Enter the new quantity: ");
            int newQuanitiy=int.Parse(Console.ReadLine());
            int quantity=currentItemUser.PurchaseCount;
            currentItemUser.PurchaseCount+=newQuanitiy;
            
            if(currentItemUser.PurchaseCount>=quantity)
            {
                currentItemUser.PriceOfOrder*=newQuanitiy;
            }
            if(currentUser.WalletBalance<currentItemUser.PriceOfOrder)
            {
              System.Console.Write("Do you want to recharge (yes/no)");
              string option=Console.ReadLine();
              
              if(option=="yes")
              {
                System.Console.Write("Enter the amount: ");
                int recharge=int.Parse(Console.ReadLine());
                currentUser.WalletRecharge(recharge);
                
              }
            }
            
           System.Console.WriteLine($"Your order id {currentOrderUser.OrderID} is modified");

         }
         
      }

      // if (flag)
      // {
      //   System.Console.WriteLine("Invalid OrderId...");
      // }


    }
    public static void OrderHistroy()
    {
      bool flag = true;
      foreach (OrderDetails order in orderList)
      {
        if (order.CustomerID.Equals(currentUser.CustomerID))
        {
          flag = false;
        }
      }
      if (!flag)
      {
        System.Console.WriteLine("OrderID	CustomerID	TotalPrice	DateOfOrder	OrderStatus");
        foreach (OrderDetails order in orderList)
        {
          if (order.CustomerID.Equals(currentUser.CustomerID))
          {
            System.Console.WriteLine($"{order.OrderID} | {order.CustomerID} | {order.TotalPrice} | {order.DateOfOrder.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
          }
        }
      }
      else
      {
        System.Console.WriteLine("There is no record for current user.");
      }

    }
    public static void ShowWalletBalance()
    {
      System.Console.WriteLine($"The current user {currentUser.Name} balance is {currentUser.WalletBalance} ");
    }
    public static void RechargeWallet()
    {
      System.Console.WriteLine("Enter the recharge amount");
      int recharge = int.Parse(Console.ReadLine());
      int rechargedAmount = currentUser.WalletRecharge(recharge);
      System.Console.WriteLine($"After recharge your updated balance is {rechargedAmount}");
    }
    public static void OrderFood()
    {

      string isValid = "yes";
      int price = 0;
      OrderDetails order = new OrderDetails(currentUser.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);
      orderList.Add(order);
      List<ItemDetails> localItemList = new List<ItemDetails>();
      string userOrderId = order.OrderID;
      do
      {
        System.Console.WriteLine("FoodID	FoodName	PricePerQuantity	QuantityAvailable");
        foreach (FoodDetails food in foodList)
        {
          System.Console.WriteLine($"{food.FoodID} | {food.FoodName} | {food.PricePerQuantity} | {food.QuantityAvailable}");
        }

        System.Console.Write("Enter the FoodID :");
        string userFoodID = Console.ReadLine().ToUpper();
        System.Console.Write("Enter the food quantity :");
        int userFoodQuantity = int.Parse(Console.ReadLine());
        bool check = true;
        foreach (FoodDetails food in foodList)
        {
          if (food.FoodID.Equals(userFoodID) && (food.QuantityAvailable >= userFoodQuantity))
          {
            currentFoodUser = food;
            check = false;
            price = userFoodQuantity * food.PricePerQuantity;
            ItemDetails item = new ItemDetails(userOrderId, food.FoodID, userFoodQuantity, price);
            food.QuantityAvailable -= item.PurchaseCount;
            localItemList.Add(item);
            System.Console.WriteLine("Do you want to continue to order more... (yes/no): ");
            isValid = Console.ReadLine();

          }
        }
        if (check)
        {
          System.Console.WriteLine("FoodID Invalid or FoodQuantity unavailable");
          isValid = "yes";
        }
      } while (isValid == "yes");
      
      System.Console.WriteLine("Do you want to confirm purchase (yes/no)");
      string isConfirm = Console.ReadLine();
      if (isConfirm == "no")
      {
        currentFoodUser.QuantityAvailable += currentItemUser.PurchaseCount;
      }
      else
      {
        string isCheck = "no";
        do
        {
          if (currentUser.WalletBalance >= price)
          {
            //OrderDetails order = new OrderDetails(currentUser.CustomerID, 0, DateTime.Now, OrderStatus.Initiated);   
            order.TotalPrice = price;
            order.OrderStatus = OrderStatus.Ordered;
            currentUser.DeductBalance(price);
            itemList.AddRange(localItemList);
            System.Console.WriteLine("Ordered booked.....");

          }
          else
          {
            System.Console.WriteLine("Insufficient  balance, Do you want to recharge .. (yes/no)");
            string isRecharge = Console.ReadLine();
            if (isRecharge == "yes")
            {
              System.Console.Write("Enter the amount to be recharge :");
              int userRecharge = int.Parse(Console.ReadLine());
              int finalAmount = currentUser.WalletRecharge(userRecharge);
              System.Console.WriteLine("$After recharge your updated balance is {rechargedAmount}");
              isCheck = "yes";
            }
            else
            {
              currentFoodUser.QuantityAvailable += currentItemUser.PurchaseCount;
            }
          }
        } while (isCheck == "yes");
      }

    }


    public static void DefaultDetails()
    {
      CustomerDetails customer1 = new CustomerDetails(10000, "Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai");
      CustomerDetails customer2 = new CustomerDetails(15000, "Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai");
      customerList.AddRange(new List<CustomerDetails> { customer1, customer2 });

      System.Console.WriteLine("CustomerID	WalletBalance	Name	FatherName	Gender	Mobile	DOB	MailID	Location");

      foreach (CustomerDetails customer in customerList)
      {
        System.Console.WriteLine($"{customer.CustomerID} | {customer.WalletBalance} | {customer.Name} | {customer.FatherName} | {customer.Gender} | {customer.Mobile} |{customer.DOB.ToString("dd/MM/yyyy")} | {customer.MailID} | {customer.Location}");
      }

      FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
      FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
      FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
      FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
      FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
      FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
      FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
      FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
      FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
      FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
      FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);

      foodList.AddRange(new List<FoodDetails> { food1, food2, food3, food3, food4, food5, food5, food6, food8, food9, food10, food11 });

      System.Console.WriteLine("FoodID	FoodName	PricePerQuantity	QuantityAvailable");
      foreach (FoodDetails food in foodList)
      {
        System.Console.WriteLine($"{food.FoodID} | {food.FoodName} | {food.PricePerQuantity} | {food.QuantityAvailable}");
      }

      OrderDetails order1 = new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
      OrderDetails order2 = new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
      OrderDetails order3 = new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
      orderList.AddRange(new List<OrderDetails> { order1, order2, order3 });
      System.Console.WriteLine("OrderID	CustomerID	TotalPrice	DateOfOrder	OrderStatus");
      foreach (OrderDetails order in orderList)
      {
        System.Console.WriteLine($"{order.OrderID} | {order.CustomerID} | {order.TotalPrice} | {order.DateOfOrder.ToString("dd/MM/yyyy")} | {order.OrderStatus}");
      }

      ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
      ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
      ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
      ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
      ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
      ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
      ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
      ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
      ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
      ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);

      itemList.AddRange(new List<ItemDetails> { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });

      System.Console.WriteLine("ItemID	OrderID	FoodID	PurchaseCount	PriceOfOrder");
      foreach (ItemDetails item in itemList)
      {
        System.Console.WriteLine($"{item.ItemID} | {item.OrderID} | {item.FoodID} | {item.PurchaseCount} | {item.PriceOfOrder}");
      }
    }
  }
}