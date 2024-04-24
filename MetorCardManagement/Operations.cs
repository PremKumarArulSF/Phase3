using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace MetorCardManagement
{
    public static class Operations
    {
        static UserDetails currentUser;
      
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();
        public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();


        public static void Mainmenu()
        {
            System.Console.WriteLine("-----Welcome to Metro card  Mangement-------");
            string mainChoice = "yes";
            do
            {

                System.Console.WriteLine("Main Menu  \n1.User Regsiration  \n2.Login user  \n3.Exit");
                int mainOption=int.Parse(Console.ReadLine());
                switch (mainOption)
                {
                    case 1:
                        {
                            System.Console.WriteLine("***Regsitration****");
                            Regsiration();
                            break;
                        }
                    case 2:
                        {
                            System.Console.WriteLine("****Login***");
                            Login();
                            break;
                        }
                    case 3:
                        {
                            mainChoice = "no";
                            System.Console.WriteLine("Exit from Main Menu");
                            break;
                        }
                }

            } while (mainChoice == "yes");
        }


        public static void Regsiration()
        {
            System.Console.Write("Enter the Username: ");
            string userName = Console.ReadLine();
            System.Console.Write("Enter the PhoneNumber: ");
            string phoneNumber = Console.ReadLine();
            System.Console.Write("Enter the Balance: ");
            int balance = int.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, phoneNumber, balance);
            System.Console.WriteLine("Registration successfully completed and CardNumber is " + user.CardNumber);
            userList.Add(user);
        }


        public static void Login()
        {
            System.Console.Write("Enter the CardNumber: ");
            string loginID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userList)
            {
                if (user.CardNumber.Equals(loginID))
                {
                    flag = false;
                    currentUser = user;
                    System.Console.WriteLine($"Welcome {user.UserName} to Login");
                    Submenu();
                    break;

                }
            }
            if (flag)
            {
                System.Console.WriteLine("Invalid CardNumber");
            }

        }





        public static void Submenu()
        {
            string subChoice = "yes";
            do
            {

                System.Console.WriteLine("SubMenu  \na.BalanceCheck \nb.Recharge  \nc.View Travel history  \nd.Travel  \ne.Exit");
                char subOption = char.Parse(Console.ReadLine());
                switch (subOption)
                {
                    case 'a':
                        {
                            System.Console.WriteLine("***Balance check***");
                            BalanceCheck();
                            break;
                        }
                    case 'b':
                        {
                            System.Console.WriteLine("****Recharge****");
                            Recharge();
                            break;
                        }
                    case 'c':
                        {
                            System.Console.WriteLine("***View Travel Histroy***");
                            ViewTravelHistroy();
                            break;
                        }
                    case 'd':
                        {
                            System.Console.WriteLine("***Travel****");
                            Travel();
                            break;
                        }
                    case 'e':
                        {
                            System.Console.WriteLine("Exit from Submenu and taking back to main menu..");
                            subChoice = "no";
                            break;
                        }
                }
            } while (subChoice == "yes");
        }


        public static void BalanceCheck()
        {
            System.Console.WriteLine($"The current user {currentUser.UserName} balance is {currentUser.Balance}");
        }

        public static void Recharge()
        {
            System.Console.Write("Enter the amount to be recharge: ");
            int recharge = int.Parse(Console.ReadLine());
            int rechargeAmount = currentUser.WalletRecharge(recharge);
            System.Console.WriteLine("After recharge your updated balance is " + rechargeAmount);
        }

        public static void Travel()
        {

            System.Console.WriteLine("TicketID | FromLocation | ToLocation | Fair");

            foreach (TicketFairDetails ticket in ticketFairList)
            {
                System.Console.WriteLine($"{ticket.TicketID} |   {ticket.FromLocation}  |{ticket.ToLocation}  | {ticket.TicketPrice}");
            }

            System.Console.Write("Enter the TicketID:");
            string userTicketId = Console.ReadLine().ToUpper();
            bool check = true;
            foreach (TicketFairDetails ticket in ticketFairList)
            {
                if (ticket.TicketID.Equals(userTicketId))
                {
                    check = false;
                    if (currentUser.Balance >= ticket.TicketPrice)
                    {
                        int userticketPrice = ticket.TicketPrice;
                        currentUser.DeductBalance(userticketPrice);
                        TravelDetails travel = new TravelDetails(currentUser.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now, ticket.TicketPrice);
                        travelList.Add(travel);
                        System.Console.WriteLine("Booked successfully...");
                    }
                    else
                    {
                        System.Console.WriteLine("Insufficent balance to travel kindly Recharge.");
                    }
                }
            }
            if (check)
            {
                System.Console.WriteLine("Invalid TicketID");
            }
        }
        public static void ViewTravelHistroy()
        {
            bool check=true;

            foreach (TravelDetails travel in travelList)
            {
                if (travel.CardNumber.Equals(currentUser.CardNumber))
                {
                    check=false;

                }
            }


            if (!check)
            {
                
                System.Console.WriteLine("TravelID | CardNumber | FromLocation | ToLocation	| Date  | TravelCost");

                foreach (TravelDetails travel in travelList)
                {
                    if (travel.CardNumber.Equals(currentUser.CardNumber))
                    {

                        System.Console.WriteLine($"{travel.TravelId}  | {travel.CardNumber}  |{travel.FromLocation}    |    {travel.ToLocation} | {travel.Date.ToString("dd/MM/yyyy")}  |  {travel.TravelCost}");
                    }
                }
            }
            else
            {
                System.Console.WriteLine("There is no travel record..");
            }
        }
        public static void DefaultDetails()
        {
            UserDetails user1 = new UserDetails("Ravi", "9848812345", 1000);
            UserDetails user2 = new UserDetails("Baskaran", "9948854321", 1000);
            userList.AddRange(new CustomList<UserDetails> { user1, user2 });

            System.Console.WriteLine("CardNumber | UserName | Phone | Balance");
            foreach (UserDetails user in userList)
            {
                System.Console.WriteLine($"{user.CardNumber}  |  {user.UserName}   |  {user.PhoneNumber}  | {user.Balance}");
            }


            TravelDetails travel1 = new TravelDetails("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL1001", "Egmore", "Koyambedu", new DateTime(2023, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL1002", "Alandur", "Koyambedu", new DateTime(2023, 11, 10), 25);
            TravelDetails travel4 = new TravelDetails("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 11, 10), 25);

            travelList.AddRange(new CustomList<TravelDetails> { travel1, travel2, travel3, travel4 });

            System.Console.WriteLine("TravelID | CardNumber | FromLocation | ToLocation	| Date | TravelCost");

            foreach (TravelDetails travel in travelList)
            {

                System.Console.WriteLine($"{travel.TravelId}  | {travel.CardNumber}  |{travel.FromLocation}  | {travel.ToLocation} | {travel.Date.ToString("dd/MM/yyyy")}  |  {travel.TravelCost}");

            }

            TicketFairDetails ticketFair1 = new TicketFairDetails("Airport", "Egmore", 55);
            TicketFairDetails ticketFair2 = new TicketFairDetails("Airport", "Koyambedu", 25);
            TicketFairDetails ticketFair3 = new TicketFairDetails("Alandur", "Koyambedu", 25);
            TicketFairDetails ticketFair4 = new TicketFairDetails("Koyambedu", "Egmore", 32);
            TicketFairDetails ticketFair5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails ticketFair6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails ticketFair7 = new TicketFairDetails("Vadapalani", "Koyambedu", 25);
            TicketFairDetails ticketFair8 = new TicketFairDetails("Arumbakkam", "Koyambedu", 16);

            ticketFairList.AddRange(new CustomList<TicketFairDetails> { ticketFair1, ticketFair2, ticketFair3, ticketFair4, ticketFair5, ticketFair6, ticketFair7, ticketFair8 });

            System.Console.WriteLine("TicketID | FromLocation | ToLocation | Fair");

            foreach (TicketFairDetails ticket in ticketFairList)
            {
                System.Console.WriteLine($"{ticket.TicketID}|   {ticket.FromLocation}  |{ticket.ToLocation}  |{ticket.TicketPrice}");
            }


        }
    }
}