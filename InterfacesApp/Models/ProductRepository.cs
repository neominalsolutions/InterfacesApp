﻿using InterfacesApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  // interfaceler bir sınıfa uygulandığında sınıf bu özellikleri yetenekleri göstermez zorunda kalır. buna biz implementation (implementasyon) diyoruz. :Interface kalıtım değil bir implementasyondur.
  // cir sınıf birden fazla interface den implente olabilir.
  public class ProductRepository:EFRepositoryBase<AppDbContext>,IRepository<Product> 
  {
 

    public void Create(Product item)
    {
      throw new NotImplementedException();
    }

    public void Delete(int id)
    {
      throw new NotImplementedException();
    }

 

    public Product FindById(int id)
    {
      return context.Products.Find(id);
    }

 

    public List<Product> ToList()
    {
      throw new NotImplementedException();
    }

    

    public void Update(int id, Product item)
    {
      throw new NotImplementedException();
    }
  }
}
