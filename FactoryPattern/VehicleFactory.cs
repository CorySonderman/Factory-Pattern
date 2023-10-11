using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        // ****When I have more time to play around maybe create 2 lists and have
        // it pull a random car/bike from the list to build. (Like a gumball
        // machine but a lot better than a plastic ring.
        public static IVehicle GetVehicle(int wheelCount)
        {
            if (wheelCount == 4)
            {
                return new Car();
            }
            else if (wheelCount == 2)
            {
                return new Motorcycle();
            }
            else 
            {
                return null; 
            }
           
            
            //switch (wheelCount)
            //{
            //    case 2:
            //        return new Car();
            //        break;
            //    case 4:
            //        return new Motorcycle();
            //        break;
            //    default:
            //        return new Car();

            //}

        }


    }
}
