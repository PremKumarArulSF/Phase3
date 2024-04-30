using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class EEEDepartment : Library
    {
        // Overridden methods set bookinfo, display info
        //static int s_serialNumber=100;
        private static int s_serialNumber=1000;
        //public string SerialNumber { get;  set;}
        
        
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
         public override string PublisherName { get; set; }
          public override int  Year { get; set; }
        public override void SetBookInfo(string authorName,string bookName,string publisherName,int year)
        {
              _serialNumber="EEE"+(++s_serialNumber);
              AuthorName=authorName;
              BookName=bookName;
              PublisherName=publisherName;
              Year=year;
        }
        public override void DisplayInfo()
        {
              System.Console.WriteLine($"SerialNo: {SerialNumber}  AuthoName: {AuthorName}  BookName: {BookName}  PublisherName: {PublisherName}  Year: {Year}");
        }
    }
}