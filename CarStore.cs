using System;
using System.Diagnostics;
using System.Reflection;
using CarStoreGarage;
using Carnamespace;
namespace CarStore
{
	public class Carstore
	{
		private string owner;
		private double income;
		private Garage garage;

		public Carstore(string owner)
        {
			this.owner = owner;
			income = 0;
			garage = new Garage();
            
		}

		public void AddCars()
		{
			Console.WriteLine("Enter Manufacturer Name: ");
			string manufacturer = Console.ReadLine();

			Console.WriteLine("Enter Model Name:");
			string model = Console.ReadLine();

			Console.WriteLine("Enter Quantity of Cars: ");
			int quantity = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter Price Of The Car: ");
			double price = double.Parse(Console.ReadLine());

			garage.AddCar(manufacturer, model, price, quantity);
		}

		public void SellCar()
		{
			Console.WriteLine("Enter Manufcaturer Name: ");
			string manufacturer = Console.ReadLine();

			Console.WriteLine("Enter Model Name: ");
			string model = Console.ReadLine();

			Console.WriteLine("Enter Quantity: ");
			int quantity = int.Parse(Console.ReadLine());

			if (garage.RemoveCar(manufacturer,model,quantity))
			{
				double cost = garage.GetCarPrice(manufacturer, model) * quantity;
				Console.WriteLine($"Sell {quantity} cars in {cost}$");
				income += cost;
			}
        }

		public void DisplayCars()
		{
			garage.DisplayCars();
		}

        public override string ToString()
        {
			int numCars = garage.GetTotalQuantity();
			return $"{owner}'s car store: Holds {numCars} cars and {income}$";
        }
    }
}
