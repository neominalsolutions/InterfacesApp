using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models.Entities
{
  // Entity
  public class Product
  {
    public int Id { get; set; }
    // bir sınıfın entity olabilmesi için Id kimlik alanına ihtiyacı vardır. Unique bir değere sahip olmalıdır.
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
    public short Stock { get; set; }

    // ForeignKey
    public int CategoryId { get; set; }

    public Category Category { get; set; }

  }

 
}
