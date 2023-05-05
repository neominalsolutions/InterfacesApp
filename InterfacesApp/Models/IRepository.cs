using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp.Models
{
  /// <summary>
  /// Interfacelerde isimlendirme I ile başlasın
  /// interfaceler her hangi bir kod blogu içermez, kod blogları interface kullana sınıflarda yazılır, sadece property ve method imzası atılır
  /// interfaceler sınıfların rehberleridir.
  /// T tipi referans tip olmak zorunda ve abstract sınıf olamaz, static sınıf olamaz.
  /// </summary>
  public interface IRepository<T> where T:class,new()
  {
    /// <summary>
    /// Yeni bir T tipinde kayıt giriş sağlar
    /// </summary>
    /// <param name="entity"></param>
    void Create(T entity); // insert, CRUD

    /// <summary>
    /// id göndrilen bir değeri silme işlemi yapar
    /// </summary>
    /// <param name="id"></param>
    void Delete(int id); // id sine göre delete

    /// <summary>
    /// id gönderilen bir nesnenin propertylerini update değiştirir.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="entity"></param>
    void Update(int id, T entity); // id sini bilip dışarıdan T tipini göndericez.

    /// <summary>
    /// T tipinde bir tablosnun pk idsine göre kayıt döndürür.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    T FindById(int id);

    /// <summary>
    /// T tipindeki bir tablodaki kayıtların listesini döndürür. select * from Products
    /// </summary>
    /// <returns></returns>
    List<T> ToList();
  }
}
