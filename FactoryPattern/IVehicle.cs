using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // ****When I have more time to play around maybe create 2 lists and have
    // it pull a random car/bike from the list to build. (Like a gumball
    // machine but a lot better than a plastic ring.
    public interface IVehicle
    {
        public void Drive();
    }
}
