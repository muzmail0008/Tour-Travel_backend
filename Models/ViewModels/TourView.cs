using System;
using MyWebApplication.Models.DomainModels;

namespace MyWebApplication.Models.ViewModels;

public class TourView
{
    public ICollection<TourPackage> TourPackages { get; set; } = [];
    public TourPackage? Tour { get; set; }
    public List<string>? TourImages { get; set; }
    public ICollection<Blogs>? TourBlog { get; set; } = [];
}
