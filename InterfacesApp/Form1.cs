using InterfacesApp.Models.Entities;
using InterfacesApp.Models;

namespace InterfacesApp
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      var p = new Product();
      p.Name = "�r�n1";
      p.UnitPrice = 10;
      p.Stock = 10;

      var pRepo = new ProductRepository();
      pRepo.Create(p);

      var p1 = pRepo.FindById(p.Id); // idsine g�re kategori buldu


      var p3 = new Product();
      p3.Name = "P13";
      p3.UnitPrice = 15;
      p3.Stock = 10;
      p3.Category = new Category();
      p3.Category.Name = "P3 Kategori1";

      pRepo.Create(p3); // hem kategori hemde �r�n olu�turur.

      var c = new Category();
      c.Name = "Kategori1";
      c.Description = "Kategori1 A��klama";

      var cRepo = new CategoryRepository();
      cRepo.Create(c);

      var k = cRepo.FindById(c.Id); // idsine g�re kategori buldu

      var c1 = new Category();
      c1.Name = "Kategori2";
      c1.Description = "Kategori2 A��klama";

      cRepo.Create(c1);

      var clist = cRepo.ToList(); // t�m kategoriler




    }
  }
}