using InterfacesApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  /// <summary>
  /// IRepository Inteface ile belirli bir standart dahilinde aynı method isimlerine sahip davranışları class kazandırmış olduk. zorunlu kıldık.
  /// </summary>
  public class CategoryRepository :EFRepositoryBase<AppDbContext>, IRepository<Category>
  {

    

    public void Create(Category item)
    {
      context.Categories.Add(item);
      SaveChanges();
    }

    public void Delete(int id)
    {
      var entity = context.Categories.Find(id);
      context.Remove(entity);
      SaveChanges();
    }

    public Category FindById(int id)
    {
      return context.Categories.Include(x => x.Products).FirstOrDefault(x => x.Id == id);
    }

    public List<Category> ToList()
    {
      return context.Categories.ToList();
    }

    public void Update(int id, Category item)
    {
      var entity = context.Categories.Find(id);
      entity.Name = item.Name;
      entity.Description = item.Description;

      //context.Categories.Update(item);

      SaveChanges();

    }

    public override int SaveChanges()
    {
      return base.SaveChanges();
    }
  }
}
