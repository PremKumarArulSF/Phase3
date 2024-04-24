using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace MovieTicketBooking
{
    public static class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("MovieTicket"))
            {
                System.Console.WriteLine("Folder created...");
                Directory.CreateDirectory("MovieTicket");
            }
            if(!File.Exists("MovieTicket/UserDetails.csv"))
            {
                System.Console.WriteLine("user file created..");
                File.Create("MovieTicket/UserDetails.csv");
            }
            if(!File.Exists("MovieTicket/TheatreDetails.csv"))
            {
                System.Console.WriteLine("Theatre file created..");
                File.Create("MovieTicket/TheatreDetails.csv");
            }
           if(!File.Exists("MovieTicket/ScreeningDetails.csv"))
            {
                System.Console.WriteLine("Screening file created..");
                File.Create("MovieTicket/ScreeningDetails.csv");
            }
            if(!File.Exists("MovieTicket/BookingDetails.csv"))
            {
                System.Console.WriteLine("booking file created..");
                File.Create("MovieTicket/BookingDetails.csv");
            }
            if(!File.Exists("MovieTicket/MovieDetails.csv"))
            {
                System.Console.WriteLine("movie file created..");
                File.Create("MovieTicket/MovieDetails.csv");
            }
        }
                
    }
}