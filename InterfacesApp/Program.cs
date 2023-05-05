using InterfacesApp.Models;
using InterfacesApp.Models.Entities;

namespace InterfacesApp
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new Form1());

      List<Product> plist = new List<Product>();
      plist.OrderBy(x => x.CategoryId).ToList();


      var pRepo = new ProductRepository();
      pRepo.OrderBy(x => x.Name);
      pRepo.FindById(1);

      var cRepo = new CategoryRepository();
      cRepo.FindById(2);


    }
  }
}