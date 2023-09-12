namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            bool input = false;
            do
            {
                Console.WriteLine($"Hello, how many wheels for this vehicle would you like to have?");
                
                input = int.TryParse(Console.ReadLine(), out wheelCount);
            }while(input == false);
            var vehicle = VehicleFactory.GetVehicle(wheelCount);
            vehicle.Drive();
        }
    }
}
