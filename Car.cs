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

        	public override string ToString()
        	{
			return $"Amount - {Quantity}, {Manufacturer} {Model}: Price is: {Price}$";
        }
    }
}
