using Core_FrameworkLayer_.DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal :IEntityRepository<Product>
    {
        //veritabanın da yapmak istediğimiz içerikleri elde ederiz. 
        //Crud işlemleri 
        //imlementelerini concrete de olur.
        //Repository Pattern yaklaşımı = Generic hale getirmek 

        // bu kısımda generic hale getirdiğimiz sınıftan  IEntityRepository<Product> otomatik olarak product sınıfı ile çalışmıs hale gelecek. 
    }
}
