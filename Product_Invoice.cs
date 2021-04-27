using System;

namespace Day4
{
        public class Product
        {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Prize { get; set; }
        public int num { get; set; }

        public Product()
        {

        }
        public void InputDetails()
        {
            Console.Write("Enter the Product Name : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter the Quantity of the Product : ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Prize of the Product : ");
            Prize = Convert.ToDouble(Console.ReadLine());
        }

        
        public class Invoice:Product
        {
            public string CustomerName { get; set; }
            public void PrintInvoice(Product[] products)
            {
                Console.WriteLine("INVOICE");
                Console.WriteLine("\n S.No \t\t Product Name \t\t Quantity \t\t Prize \t\t Total Prize");
                int index = 1;
                foreach(var item in products)
                {
                    Console.Write(index);
                    Console.Write("\t\t");
                    Console.Write(item.ProductName);
                    Console.Write("\t\t\t\t");
                    Console.Write(item.Quantity);
                    Console.Write("\t\t\t");
                    Console.Write(item.Prize);
                    Console.Write("\t\t\t");
                    Console.Write(item.Prize*Quantity);
                    Console.WriteLine();
                    index = index + 1;
                }
            }
        }
        class User
        {
            public static void Main()
            {
                Product[] products = new Product[2];
                
                for(int i = 0; i < products.Length; i++)
                {
                    Product product = new Product();
                    product.InputDetails();
                    products[i] = product;
                }
                Invoice invoice = new Invoice();
                invoice.PrintInvoice(products);
            }
        }
    }
}