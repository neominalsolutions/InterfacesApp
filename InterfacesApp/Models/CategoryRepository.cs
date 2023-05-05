using InterfacesApp.Models.Entities;
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
  public class CategoryRepository : IRepository<Category>
  {
    public void Create(Category item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

    public Category FindById(int id)
    {
      throw new NotImplementedException();
    }

    public List<Category> ToList()
    {
      throw new NotImplementedException();
    }

    public void Update(int id, Category item)
    {
      throw new NotImplementedException();
    }
  }
}
