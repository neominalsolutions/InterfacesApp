namespace InterfacesApp.Models.Entities
{
  public class Supplier
  {
    public int Id { get; set; }
    public string Name { get; set; }

    // Tedarikçinin ürünleri
    public List<Product> Products { get; set; }
  }
}