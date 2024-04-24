using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace MetorCardManagement
{
    public static class MetroCardManagement
    {

      public static void Create()
      {
          if(!Directory.Exists("MetroCard"))
          {
             System.Console.WriteLine("Folder Created..");
             Directory.CreateDirectory("MetroCard");
          }
          if(!File.Exists("MetroCard/UserDetails.csv"))
          {
            System.Console.WriteLine("User details File created...");
            File.Create("MetroCard/UserDetails.csv");
          }
          if(!File.Exists("MetroCard/TravelDetails.csv"))
          {
            System.Console.WriteLine("Travel details file created.. ");
            File.Create("MetroCard/TravelDetails.csv"); 
          }
          if(!File.Exists("MetroCard/TicketFairDetails.csv"))
          {
            System.Console.WriteLine("Ticket Fair details file created...");
            File.Create("MetroCard/TicketFairDetails.csv");
          }
      }  
          
     }
}