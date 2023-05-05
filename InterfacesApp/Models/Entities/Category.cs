namespace InterfacesApp.Models.Entities
{
  public class Category
  {

    public int Id { get; set; }
    public string Name { get; set; }

    /// <summary>
    ///  Kategorideki ürünler
    /// </summary>
    public List<Product> Products { get; set; }

   
  }
}