using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public abstract class Library
    {
//         Field : serial number -LIB1000

// Property : serial number

// Abstract properties:, author name, book name, publisher name, year

// Abstract methods: set book info, display info

   
   public string _serialNumber;
   public string SerialNumber { get{return _serialNumber;}}
   public abstract string AuthorName { get; set; }
   public abstract string BookName { get; set; }
   public abstract string PublisherName { get; set; }
   public abstract int  Year { get; set; }

   public abstract void SetBookInfo(string authorName,string bookName,string publisherName,int year);
   public abstract void DisplayInfo();


   
   
   
   
   
   
   
   
   
   
    }
}