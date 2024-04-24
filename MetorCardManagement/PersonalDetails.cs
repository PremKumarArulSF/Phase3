using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetorCardManagement
{
    public class PersonalDetails
    {


 public string UserName { get; set; }//Auto Property
 public string PhoneNumber { get; set; } //Auto Property

/// <summary>
/// The PersonlDetails paramterised constructors used to assign a values to its properties
/// </summary>
/// <param name="userName">UserName property used to hold a userName values(string type)</param>
/// <param name="phoneNumber">PhoneNumber property used to hold a phoneNumber values(string type)</param> 
 public PersonalDetails(string userName,string phoneNumber)

{
  UserName=userName;
  PhoneNumber=phoneNumber;
}

/// <summary>
/// The PersonalDetails call when userDetails single paramterised constructors is called.
/// </summary>

public PersonalDetails()
{
   
}
 
 
 

    }
}