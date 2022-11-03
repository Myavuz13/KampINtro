using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
}//void--git işlemi yap- bitir---herhangi bir dönüşe ihtiyaç yoksa kullanılır. işlem sonucu başka yerde kullanılacaksa "public int" return ile birlikte kullanılır v
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }
                  }
}
