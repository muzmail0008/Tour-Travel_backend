using System;
using System.ComponentModel.DataAnnotations;

namespace MyWebApplication.Models.DomainModels;

public class Blogs
{
    [Key]
    public Guid BlogId { get; set; } = Guid.NewGuid();
    public required string BlogImage { get; set; }

    public required string BlogTitle { get; set; }
    
    public required string BlogDescription { get; set; }

}
