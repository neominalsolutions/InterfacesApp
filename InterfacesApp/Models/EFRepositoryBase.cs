using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  // TContext farklı DbContextler ile çalışmamızı sağlayacak
  public abstract class EFRepositoryBase<TContext> where TContext:DbContext,new()
  {
    protected TContext context = new TContext();

    /// <summary>
    /// Bütün tablolar save işlemi yapacağı için kalıtım ile kod hepsi için ortak kullandık.
    /// </summary>
    /// <returns></returns>
    public virtual int SaveChanges()
    {
      
      return context.SaveChanges();
    }

  }
}
