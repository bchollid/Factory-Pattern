namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            string userStringEntry = Console.ReadLine();
            int userNumber;
            if(!Int32.TryParse(userStringEntry, out userNumber))
            {
                Console.WriteLine("Please enter a valid number of wheels");
                return;
            }
            var newCar = VehicleFactory.GetVehicle(userNumber);
            newCar.Drive();
            Console.ReadLine();
        }
    }
}
