using Car_GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mashini_MDI
{
    [Serializable]
    public class Lists
    {
        List<Car> cars;
        List<Truck> trucks;

        public Lists(List<Car> c, List<Truck> t)
        {
            cars = c;
            trucks = t;
        }

        public List<Car> Cars
        {
            get { return cars; }
        }

        public List<Truck> Trucks
        {
            get { return trucks; }
        }
    }
}
