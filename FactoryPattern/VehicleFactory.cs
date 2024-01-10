using System;
namespace FactoryPattern
{
	public class VehicleFactory
	{
		public VehicleFactory()
		{
		}

		public static IVehicle GetVehicle(int wheelInput)
		{
                switch (wheelInput)
                {
                    case 2:
                        return new Motorcycle();
					case 4:
						return new SUV();
					case 6:
						return new SemiTruck();
					default:
						return new NotKnownVehicle();

				}	
        }
	}
}

