using System;
namespace FactoryPattern
{
	public class SUV : IVehicle
	{
		public SUV()
		{
		}

		public void Drive()
		{
			Console.WriteLine("Building an SUV!");
		}
	}
}

