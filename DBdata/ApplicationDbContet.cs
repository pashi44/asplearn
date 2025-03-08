using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System;   
using  firstone.Models;

namespace  firstone.DBdata{


public class ApplicationDbContent :DbContext{
    public  ApplicationDbContent(DbContextOptions<ApplicationDbContent> options)
    : base(options){}

    public DbSet<Employees> employees{get;set;}


protected  override     void  OnModelCreating(ModelBuilder  modelBuilder) {

modelBuilder.Entity<Employees>().HasData( 
    new Employees {
// 
Id =1,
 Code  = "coder",
  FirstName= "prashanth",
LastName= "Nuthula", 
Gender = "Male",
Email = "pashierddi@gmail.com",
Phone = "816 203 9740",
JobTitle ="Unemployed"
// 
}
// 
);



}

}
    //https://www.google.com/books/edition/Programming_ASP_NET_Core/5LdZDwAAQBAJ?hl=en&gbpv=1&pg=PT8&printsec=frontcover

}