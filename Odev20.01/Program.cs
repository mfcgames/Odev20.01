using System;
using System.Collections.Generic;

namespace Odev20._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Pc";
            product1.ProductValue = 11750;
            product1.Storage = 2000;
            product1.Category = "Elektronik";
            Product product2 = new Product();
            product2.Id = 2;
            product2.ProductName = "Blender";
            product2.ProductValue = 860;
            product2.Storage = 7200;
            product2.Category = "Ev Aletleri";
            Product product3 = new Product();
            product3.Id = 3;
            product3.ProductName = "Toka";
            product3.ProductValue = 7.5;
            product3.Storage = 10000;
            product3.Category = "Züccaciye";

            Product[] products = new Product[] {product1,product2,product3 };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("ÜRÜN ID >>" + products[i].Id + "\n" + "KATEGORİ >> " +products[i].Category+" \n"+"ÜRÜN İSMİ >> "+products[i].ProductName+"\n"+"ÜRÜN FİYATI >> "+products[i].ProductValue+"\n"+"ÜRÜN STOK ADEDİ >> "+products[i].Storage);
            }
            Console.WriteLine("\n***\n***");
            foreach (var product in products)
            {
                
                Console.WriteLine("ÜRÜN ID >>" + product.Id + "\n" + "KATEGORİ >> " +product.Category+ " \n" + "ÜRÜN İSMİ >> "+product.ProductName + "\n" + "ÜRÜN FİYATI >> "+product.ProductValue+ "\n" + "ÜRÜN STOK ADEDİ >> "+product.Storage);
            }
            Console.WriteLine("\n***\n***");
            int j = 0;
            while (j<products.Length)
            {
                Console.WriteLine("ÜRÜN ID >>"+products[j].Id+"\n"+"KATEGORİ >> " + products[j].Category + " \n" + "ÜRÜN İSMİ >> " +products[j].ProductName + "\n" + "ÜRÜN FİYATI >> " + products[j].ProductValue + "\n" + "ÜRÜN STOK ADEDİ >> " + products[j].Storage);
                j++;
            }
        }
        
    }
    class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Storage { get; set; }
        public double ProductValue { get; set; }
        public string Category { get; set; }
    }
 
}
