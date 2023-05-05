using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  // TContext farklı DbContextler ile çalışmamızı sağlayacak
  public abstract class EFRepositoryBase<TContext>
  {
    protected TContext context;
   

    public EFRepositoryBase(TContext context)
    {
      this.context = context;
    }


    public virtual int SaveChanges()
    {
      return 1;
    }

  }
}
