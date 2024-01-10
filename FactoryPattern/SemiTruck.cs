using System;
namespace FactoryPattern
{
	public class SemiTruck: IVehicle
	{
		public SemiTruck()
		{
		}

		public void Drive()
		{
			Console.WriteLine("Building a semi truck!");
		}
	}
}

