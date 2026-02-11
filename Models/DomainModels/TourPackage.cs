using System;
using System.ComponentModel.DataAnnotations;
namespace MyWebApplication.Models.DomainModels;

public class TourPackage
{
    [Key]
    public Guid TourId { get; set; } = Guid.NewGuid();
    public required string TourImage { get; set; }
    public string? Destination { get; set; }
    public string? Days { get; set; }
    public string? Nights { get; set; }
    public string? PlacesCovered { get; set; }
    public string? Price { get; set; }
    public string? Description { get; set; }
    public string? Titile { get; set; }
    public string? Include { get; set; }

}