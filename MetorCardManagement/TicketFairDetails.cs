using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetorCardManagement
{
    public class TicketFairDetails
    {


  private static int s_ticketID=3000; //Private static field
  public string TicketID { get;  } //Readonly property
  public string FromLocation { get; set; } //AutoProperty
  public string ToLocation { get; set; } //AutoProperty
  public int TicketPrice { get; set; } //AutoProperty



 /// <summary>
 /// The ticketFairDetails paramterised constructor used to assign a value to its properties
 /// </summary>
 /// <param name="fromLocation">FromLoaction property used to hold a fromlocation value(string type)</param>
 /// <param name="toLocation">ToLoaction property used to hold a Tolocation value(string type)</param>
 /// <param name="ticketPrice">TicketPrice property used to hold a TicketPrice value(interger type)</param>
  public TicketFairDetails(string fromLocation,string  toLocation,int ticketPrice)
  {
    TicketID="MR"+(++s_ticketID);
    FromLocation=fromLocation;
    ToLocation=toLocation;
    TicketPrice=ticketPrice;
  }

  /// <summary>
  /// The single paramertised TicketFairDetails constructors used to assign a value
  /// </summary>
  /// <param name="ticket">It contains ticketFairdetails value</param>
  public TicketFairDetails(string ticket)
  {
    string [] value=ticket.Split(",");
    TicketID=value[0];
    s_ticketID=int.Parse(value[0].Remove(0,2));
    FromLocation=value[1];
    ToLocation=value[2];
    TicketPrice=int.Parse(value[3]);
  }
  
  
  
    
  
  
  

    }
}