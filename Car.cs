using System;
namespace Carnamespace
{
	public class Car
	{
		public string Manufacturer { get; set; }
		public string Model { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Car(string manufacturer,string model,double price, int quantity)
		{
			Manufacturer = manufacturer;
			Model = model;
			Price = price;
			Quantity = quantity;
		}

		public void Add(int amount)
		{
			Quantity += amount;
		}

		public bool Remove(int amount)
		{
			if (Quantity >= amount)
			{
				Quantity -= amount;
				return true;
			}
			else
			{
				Console.WriteLine("Not Enough Cars");
				return false;
			}
		}

        public override string ToString()
        {
			return $"Amount - {Quantity}, {Manufacturer} {Model}: Price is: {Price}$";
        }
    }
}

