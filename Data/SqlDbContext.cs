using System;
using Microsoft.EntityFrameworkCore;
using MyWebApplication.Models;
using MyWebApplication.Models.DomainModels;


namespace MyWebApplication.Data;

public class SqlDbContext : DbContext
{

public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }

//entities
 
    public DbSet<User> Users { get; set; }
     public DbSet<Blogs> Blogs { get; set; }
    public DbSet<TourPackage> TourPackages { get; set; }
   
    public DbSet<Contact> Contact { get; set; }
    public DbSet<TourBooking> TourBooking { get; set; }


}