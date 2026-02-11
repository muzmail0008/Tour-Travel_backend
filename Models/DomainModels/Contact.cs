using System;

namespace MyWebApplication.Models.DomainModels;

public class Contact
{
 public Guid ContactId { get; set; } = Guid.NewGuid(); //pk
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Message { get; set; }
   
}
