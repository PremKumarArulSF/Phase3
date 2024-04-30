using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NumberTwo
{
    public class BookInfo :RackInfo
    {
        private static int s_bookID=100;
        public string BookID { get;  }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        public BookInfo(int rackNumber,int columnNumber,string bookName,string authorName,int price) :base(rackNumber, columnNumber)
        {
            BookID="BID"+(++s_bookID);
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }

        public void DisplayInfo()
        {
             System.Console.WriteLine($"BookID: {BookID} \nDepartment: {DepartmentName} \nDegree: {Degree} \nRackNumber: {RackNumber} \nColumNumber: {ColumnNumber}");
             System.Console.WriteLine($"BookName: {BookName} \nAuthorName: {AuthorName} \nPrice:{Price}");
        }
        
        
        
        
        
        
        
    }
}