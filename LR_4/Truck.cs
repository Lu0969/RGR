using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GUI
{
    [Serializable]
    public class Truck: Car
    {
        int tonnage;

        public Truck() { }

        public Truck(String brand, int power, int ton, int price, List<DateTime> repaires) : base(brand, power, price, repaires)
        {
            tonnage = ton;
        }

        public int Tonnage
        {
            get { return tonnage; }
            set { tonnage = value; }
        }

        new public String ListItem
        {
            get { return "T " + Brand + " " + Price; }
        }
    }
}
