namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wheelCount;
            IVehicle vehicle = null;


            //bool answer = false;
            //do
            //{
            //    //*****What if they input 5? - Fixed
            //    Console.WriteLine("Would you like 2 tires or 4 on your new ride?");
            //    answer = int.TryParse(Console.ReadLine(), out wheelCount );
            //} while (answer == false);

            // var vehicle = VehicleFactory.GetVehicle(wheelCount);
            do
            {
                Console.WriteLine("For your new ride do you want 4 wheels or 2?");
                if (int.TryParse(Console.ReadLine(), out wheelCount))
                {
                    vehicle = VehicleFactory.GetVehicle(wheelCount);
                    if (vehicle == null)
                    {
                        Console.WriteLine("Sorry but my factory is only " +
                            "equipped for cars and motorcycles.  Please " +
                            "choose 2 or 4.");
                        Console.WriteLine();
                    }
                    
                }
                else
                {
                    Console.WriteLine("That was not even a number.  Do you " +
                            "want a new ride or not?  Please choose 2 or 4.");
                    Console.WriteLine();    
                }

            } while (vehicle == null);


            vehicle.Drive();

        }

    }
}
