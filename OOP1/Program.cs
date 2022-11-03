using OOP1;
using System;

namespace KampINtro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1=new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "masa";
            product1.UnitPrize = 500;
            product1.UnitsInStock = 13;
            Product product2 = new Product { ID = 3, CategoryID = 4, ProductName = "sandalye", UnitPrize = 100, UnitsInStock = 23 };
            //PascalCase    //camelCase büyük harfla yazım kuralı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            

        }
    }
}
