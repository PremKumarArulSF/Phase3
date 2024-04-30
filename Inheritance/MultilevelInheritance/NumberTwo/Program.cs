using System;
using NumberTwo;
class Program{
    public static void Main(string[] args)
    {
        BookInfo book1=new BookInfo(1,23,"Bascis of c","Karun",200);
        BookInfo book2=new BookInfo(21,34,"Electronics","Shujatha",250);
        BookInfo book3=new BookInfo(11,32,"DSP","Mohan",300);
        book1.DisplayInfo();
        book2.DisplayInfo();
        book3.DisplayInfo();
    }
}
