using InterfacesApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  // EF ile veritabanı bağlantısını bu class ile yöneticeğiz.
  public class AppDbContext:DbContext
  {
    // database modelleme aşamasında DbSet ile program nesnelerini database tablolarına dönüştürmek için kullanıyoruz
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public AppDbContext()
    {

    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      // veri tabanına bağlantıyı bu method içerisine yazacağımız kodlar ile yapıyoruz

      optionsBuilder.UseSqlServer("Server=(localDB)\\MSSQLLocalDB;Database=Test102DB;Trusted_Connection=True;MultipleActiveResultSets=True;");

      base.OnConfiguring(optionsBuilder);
    }




  }
}
