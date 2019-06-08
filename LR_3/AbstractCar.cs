using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GUI
{
    public class AbstractCar
    {
        private String brand;
        private int power;

        public AbstractCar(string brand, int power)
        {
            this.brand = brand;
            this.power = power;
        }

        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }
    }
}
