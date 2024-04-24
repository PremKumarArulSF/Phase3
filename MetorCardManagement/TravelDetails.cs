using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetorCardManagement
{
    public class TravelDetails
    {
    
      private static int s_travelID=2000;//Private static field
      public string TravelId { get; } //Read-only property
      public string  CardNumber{ get; set; } //AutoProperty
      public string FromLocation{get;set;}//Auto Property
      public string ToLocation { get; set; } //Auto Property
       public DateTime Date { get; set; } //Auto Property
       public int  TravelCost { get; set; } //Auto Property
       

       /// <summary>
       /// The TravelDetails paramterised constructor used to assign a values to its property
       /// </summary>
       /// <param name="cardNumber">The Cardnumber property used to hold a cardnumber value (string type).</param>
       /// <param name="fromLocation">FromLocation property used to hold a fromLocation value(string type)</param>
       /// <param name="toLocation">ToLocation property used to hold a toLocation value(string type_</param>
       /// <param name="date">Date property used to hold a date value(DateTime format)</param>
       /// <param name="travelCost">TravelCost property used to hold a travelCost value(interger type)</param>
       public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,int travelCost)
       {
        TravelId="TID"+(++s_travelID);
        CardNumber=cardNumber;
        FromLocation=fromLocation;
        ToLocation=toLocation;
        Date=date;
        TravelCost=travelCost;
       }

       /// <summary>
       /// Travel single parameterised constructors used to assign value to its properties. 
       /// </summary>
       /// <param name="travel">travel paramter contains a travel details values </param> 
      
       
       public TravelDetails(string travel)
       {
        string [] value=travel.Split(",");
        TravelId=value[0];
        s_travelID=int.Parse(value[0].Remove(0,3));
        CardNumber=value[1];
        FromLocation=value[2];
        ToLocation=value[3];
        Date=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
        TravelCost=int.Parse(value[5]);
       }
       
             
      
      
      
      
      
    }
}