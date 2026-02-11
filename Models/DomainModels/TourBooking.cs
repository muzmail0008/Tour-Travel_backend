using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApplication.Models.DomainModels;

public class TourBooking
{
    [Key]
    public Guid BookingId { get; set; } = Guid.NewGuid();
    public Guid? TourId { get; set; }

    [ForeignKey("TourId")]
    public TourPackage? Tour { get; set; }


    public required string Name { get; set; }

    public required string Email { get; set; }

    public required string Phone { get; set; }

    public required string Travelers { get; set; }

    public string? Package { get; set; }

    public required string StartDate { get; set; }

    public string? EndDate { get; set; }

    public required string HotelCategory { get; set; }
    public required string RoomCount { get; set; }
    public string? Requests { get; set; }
    public string? Transport { get; set; }

}
