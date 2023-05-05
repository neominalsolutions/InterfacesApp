using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  public interface ISortableRepository<T> where T:class,new()
  {
    /// <summary>
    /// x=> x.Name gibi yazılması için Expression<Func<T, bool>> tipi kullanılır.
    /// </summary>
    /// <param name="expression"></param>
    void OrderBy(Expression<Func<T, string>> expression);
  }
}
