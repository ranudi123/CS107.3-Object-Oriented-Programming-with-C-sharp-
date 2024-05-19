using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Q3
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

        public Product(int productId, string productName, double price, int quantityInStock)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            QuantityInStock = quantityInStock;
        }

        public void AddProduct(int productId, string productName, double price, int quantityInStock)
        {
            Console.WriteLine($"Product added: ID {productId}, Name: {productName}, Price: ${price}, Quantity: {quantityInStock}");
        }

        public void BuyProduct(int productId, int quantity)
        {
            if (QuantityInStock >= quantity)
            {
                QuantityInStock -= quantity;
                Console.WriteLine($"Sold {quantity} units of product ID {productId}.");
            }
            else
            {
                Console.WriteLine($"Insufficient stock for product ID {productId}. Only {QuantityInStock} units available.");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            
            Product laptop = new Product(101, "Laptop", 800.00, 10);

            Console.WriteLine($"Product ID: {laptop.ProductId}");
            Console.WriteLine($"Product Name: {laptop.ProductName}");
            Console.WriteLine($"Price: ${laptop.Price}");
            Console.WriteLine($"Quantity in Stock: {laptop.QuantityInStock}");
            Console.ReadLine();



            laptop.AddProduct(102, "Headphones", 50.00, 25);

       
            laptop.BuyProduct(101, 2); 
            laptop.BuyProduct(101, 9);

            Console.ReadLine();
        }
    }
}
