using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace MetorCardManagement
{
    public static class FileHandling
    {
        
        public static void Create()
        {
           if(!Directory.Exists("MetroCard"))
           {
            System.Console.WriteLine("Folder created...");
            Directory.CreateDirectory("MetroCard");
           }
           if(!File.Exists("MetroCard/UserDetails.csv"))
           {
            System.Console.WriteLine("User file created...");
            File.Create("MetroCard/UserDetails.csv").Close();
           }
           if(!File.Exists("MetroCard/TravelDetails.csv"))
           {
             System.Console.WriteLine("Travel details file created...");
            File.Create("MetroCard/TravelDetails.csv").Close();
           }
           if(!File.Exists("MetroCard/TicketFairDetails.csv"))
           {
            System.Console.WriteLine("TicketFairDetails file created...");
            File.Create("MetroCard/TicketFairDetails.csv").Close();
           }
        }

        public static void WriteToCSV()
        {
           string [] users=new string[Operations.userList.Count];
           for(int i=0;i<Operations.userList.Count;i++)
           {
            users[i]=Operations.userList[i].CardNumber+","+Operations.userList[i].UserName+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;
           }
           File.WriteAllLines("MetroCard/UserDetails.csv",users);

           string[] travels=new string[Operations.travelList.Count];
           for(int i=0;i<Operations.travelList.Count;i++)
           {
            travels[i]=Operations.travelList[i].TravelId+","+Operations.travelList[i].CardNumber+","+Operations.travelList[i].FromLocation+","+Operations.travelList[i].ToLocation+","+Operations.travelList[i].Date.ToString("dd/MM/yyyy")+","+Operations.travelList[i].TravelCost;
        
           }
           File.WriteAllLines("MetroCard/TravelDetails.csv",travels);

           string [] ticketFairs=new string[Operations.ticketFairList.Count];
           for(int i=0;i<Operations.ticketFairList.Count;i++)
           {
            ticketFairs[i]=Operations.ticketFairList[i].TicketID+","+Operations.ticketFairList[i].FromLocation+","+Operations.ticketFairList[i].ToLocation+","+Operations.ticketFairList[i].TicketPrice;

           }
           File.WriteAllLines("MetroCard/TicketFairDetails.csv",ticketFairs);
        }

        public static void ReadFromCSV()
        {
            string [] users=File.ReadAllLines("MetroCard/UserDetails.csv");
            foreach(string user in users)
            {
               UserDetails user1=new UserDetails(user);
               Operations.userList.Add(user1);
            }
            string [] travels=File.ReadAllLines("MetroCard/TravelDetails.csv");
            foreach(string travel in travels)
            {
                 TravelDetails travel1=new TravelDetails(travel);
                 Operations.travelList.Add(travel1);
            }

            string[] tickets=File.ReadAllLines("MetroCard/TicketFairDetails.csv");
            foreach(string ticket in tickets)
            {
                TicketFairDetails ticket1=new TicketFairDetails(ticket);
                Operations.ticketFairList.Add(ticket1);
            }
        }
    }
}