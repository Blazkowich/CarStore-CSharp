using System;
using Carnamespace;
using CarStore;
namespace CarStoreGarage
{
	public class Garage
	{
		private Dictionary<(string, string), Car> carGarage;

		public Garage()
		{
			carGarage = new Dictionary<(string, string), Car>();
		}

		public void AddCar(string manufacturer, string model,double price,int quantity)
		{
			var carKey = (manufacturer, model);

			if (carGarage.ContainsKey(carKey))
			{
				carGarage[carKey].Quantity += quantity;
			}
			else
			{
				carGarage[carKey] = new Car(manufacturer, model, price, quantity);
			}
		}

		public bool RemoveCar(string manufacturer, string model, int quantity)
		{
			var carKey = (manufacturer, model);

			Car car = carGarage[carKey];

			if (carGarage.ContainsKey(carKey))
			{

				if (car.Quantity >= quantity)
				{
					car.Quantity -= quantity;
					if (car.Quantity == 0)
					{
						carGarage.Remove(carKey);
					}
					return true;
				}
				else
				{
					Console.WriteLine("Not Enough Cars");
				}
			}
			else
			{
				Console.WriteLine("Requested Car Doesn't Exits.");
			}
			return false;
		}


		public double GetCarPrice(string manufacturer, string model)
		{
			var carKey = (manufacturer, model);

			if (carGarage.ContainsKey(carKey))
			{
				return carGarage[carKey].Price;
			}

			return 0;
		}

		public void DisplayCars()
		{
			var sortedCars = carGarage.Values.OrderBy(c => c.Manufacturer).ThenBy(c => c.Model);

			foreach (var car in sortedCars)
			{
				Console.WriteLine(car);
			}
		}

		public int GetTotalQuantity()
		{
			return carGarage.Values.Sum(c => c.Quantity);
		}
	}
}

