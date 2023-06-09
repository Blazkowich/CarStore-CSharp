using System;
using System.Diagnostics;
using System.Reflection;
using Carnamespace;
namespace CarStore
{
	public class Carstore
	{
		private string owner;
		private double income;
		private Dictionary<(string, string), Car> carsGarage;

		public Carstore(string owner)
        {
			this.owner = owner;
			income = 0;
            carsGarage = new Dictionary<(string, string), Car>();
            
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

			var carKey = (manufacturer, model);

			if (carsGarage.ContainsKey(carKey))
			{
				carsGarage[carKey].Add(quantity);
			}
			else
			{
				carsGarage[carKey] = new Car(manufacturer, model, price, quantity);
			}
		}

		public void SellCar()
		{
			Console.WriteLine("Enter Manufcaturer Name: ");
			string manufacturer = Console.ReadLine();

			Console.WriteLine("Enter Model Name: ");
			string model = Console.ReadLine();

			Console.WriteLine("Enter Quantity: ");
			int quantity = int.Parse(Console.ReadLine());

			var carKey = (manufacturer, model);

			if (!carsGarage.ContainsKey(carKey))
			{
				Console.WriteLine("Requested Car Doesn't Exist.");
			}
			else
			{
				Car car = carsGarage[carKey];
				if (!car.Remove(quantity))
				{
					return;
				}
				double cost = car.Price * quantity;
				Console.WriteLine($"Sell {quantity} cars for {cost}$");
				income += cost;

				if(car.Quantity == 0)
				{
					carsGarage.Remove(carKey);
				}
			}
        }

		public void DisplayCars()
		{
			var sortedCars = carsGarage.Values.OrderBy(c => c.Manufacturer).ThenBy(c => c.Model);

			foreach (var car in sortedCars)
			{
				Console.WriteLine(car);
			}
		}

        public override string ToString()
        {
			int numCars = carsGarage.Values.Sum(c => c.Quantity);
			return $"{owner}'s car store: Holds {numCars} cars and {income}$";
        }
    }
}

