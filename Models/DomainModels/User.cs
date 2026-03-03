using System;
using System.ComponentModel.DataAnnotations;
using backend_tour_website.Types;
 

namespace MyWebApplication.Models;


public class User
{
  [Key]
    public  Guid UserId {get;set;} = Guid.NewGuid();
    // public required string  Username {get ;set;}
    public required string  Email {get ;set;}
    public required string  Password {get ;set;}
    // public string?  ProfilePicUrl {get ;set;}
    // public string? Phone {get; set ; }
 
    //  public Role Role {get; set;} = Role.User;
}

