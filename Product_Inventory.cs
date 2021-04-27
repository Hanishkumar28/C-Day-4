using System;

namespace Day4
{
	public class Product1
	{
		public string Customer { get; set; }
		public string ProductCode { get; set; }
		public int ProductQuantity { get; set; }
		public int TotalQuantity { get; set; }
		public void GetProductDetails()
		{
			Console.WriteLine("Enter Customer mode :");
			Customer = Console.ReadLine();
			Console.WriteLine("Enter Product Code :");
			ProductCode = Console.ReadLine();
		}
	}
	class Inventory : Product1
	{
		public void PrintInvoice()
		{
			TotalQuantity = 100;
			if (Customer == "Buyer")
			{
				Console.WriteLine("Enter Product Quantity  :");
				ProductQuantity = Convert.ToInt32(Console.ReadLine());
				TotalQuantity = TotalQuantity - ProductQuantity;
				Console.WriteLine("New Total Quantity  :" + TotalQuantity);
			}
			else if (Customer == "Wholeseller")
			{
				Console.WriteLine("Enter Product Quantity  :");
				ProductQuantity = Convert.ToInt32(Console.ReadLine());
				TotalQuantity = TotalQuantity + ProductQuantity;
				Console.WriteLine("New Total Quantity  :" + TotalQuantity);
			}
		}
	}
	public class User
	{
		public static void Main()
		{
			Inventory inventory = new Inventory();
			inventory.GetProductDetails();
			inventory.PrintInvoice();
		}
	}
}
