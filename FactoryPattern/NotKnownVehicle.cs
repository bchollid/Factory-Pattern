using System;
namespace FactoryPattern
{
	public class NotKnownVehicle : IVehicle
	{
		public NotKnownVehicle()
		{
		}

		public void Drive()
		{
			Console.WriteLine("Sorry, a vehicle with that number of wheels isn't programmed in.");
		}
	}
}

