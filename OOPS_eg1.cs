using System;

public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double Prize { get; set; }
        public string Customer { get; set; }
        public string ProductCode { get; set; }
        public int TotalQuantity = 100;
        public double TotalPrize { get; set; }
        public void InputDetails_fixed()
        {
            Console.Write("Enter the Product Name : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter the Prize of the each Product : ");
            Prize = Convert.ToDouble(Console.ReadLine());
        }
        public void InputDetails_buy()
        {
            Console.Write("Enter the Product Name to buy : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter Quantity of the Product to buy : ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Prize of the each Product : ");
            Prize = Convert.ToDouble(Console.ReadLine());
            TotalQuantity = TotalQuantity - Quantity;
            TotalPrize = Quantity * Prize;
        }
        public void InputDetails_add()
        {
            Console.Write("Enter the Product Name to be added : ");
            ProductName = Console.ReadLine();
            Console.Write("Enter Quantity of the Product to be added : ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            TotalQuantity = TotalQuantity + Quantity;
            Console.Write("Enter the Prize of the each Product : ");
            Prize = Convert.ToDouble(Console.ReadLine());
        }

        public class Invoice : Product
        {
            public string CustomerName { get; set; }
            public void PrintInvoice(Product[] products)
            {
                Console.WriteLine("INVOICE");
                Console.WriteLine("\n S.No \t\t Product Name \t Total Quantity \t Buying Quantity \t Prize of Each \t Total Prize");
                int index = 1;
                foreach (var item in products)
                {
                    Console.Write(index);
                    Console.Write("\t\t");
                    Console.Write(item.ProductName);
                    Console.Write("\t\t\t");
                    Console.Write(item.TotalQuantity);
                    Console.Write("\t\t\t");
                    Console.Write(item.Quantity);
                    Console.Write("\t\t\t");
                    Console.Write(item.Prize);
                    Console.Write("\t\t\t");
                    Console.Write(item.TotalPrize);
                    Console.Write("\t\t");
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

                for (int i = 0; i < products.Length; i++)
                {
                    Product product = new Product();
                    product.InputDetails_fixed();
                    products[i] = product;
                }
                Invoice invoice = new Invoice();
                invoice.PrintInvoice(products);

                Console.WriteLine("Enter the code 1-ADD or 2-BUY products or 3-Exit");
                int code = Convert.ToInt32(Console.ReadLine());
                switch(code)
                {
                    case 1:
                        for (int i = 0; i < products.Length; i++)
                        {
                            Product product = new Product();
                            product.InputDetails_add();
                            products[i] = product;
                        }
                        Invoice invoice_add = new Invoice();
                        invoice_add.PrintInvoice(products);
                        break;
                    case 2:
                        for (int i = 0; i < products.Length; i++)
                        {
                            Product product = new Product();
                            product.InputDetails_buy();
                            products[i] = product;
                        }
                        Invoice invoice_buy = new Invoice();
                        invoice_buy.PrintInvoice(products);
                        break;
                    case 3:
                        break;
                }
                                   
            }
        }


    }