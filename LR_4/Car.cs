using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_GUI
{
    [Serializable]
    public class Car : AbstractCar, ITesla, INormalCar
    {
        int price;
        List<DateTime> repaireDate;

        public Car() { }

        public Car(String brand, int power, int price, List<DateTime> repaireDate) : base(brand, power)
        {
            this.price = price;
            this.repaireDate = repaireDate;
        }

        public Car(String brand, int power, int price) : base(brand, power)
        {
            this.price = price;
            this.repaireDate = new List<DateTime>();
        }

        //Коллизия имен методов интерфейсов исправлена перегрузкой методов
        public void Move(int speed)
        {
            Console.WriteLine("Ручное управление. Текущая скорость: " + speed);
        }

        public void Move(String address)
        {
            Console.WriteLine("Автопилот. Движение по адресу: " + address);
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public List<DateTime> RepaireDate
        {
            get { return repaireDate; }
            set { repaireDate = value; }
        }
        //Индексатор. Получает доступ к определенному элементу списка
        public DateTime this[int i]
        {
            get { return repaireDate[i]; }
            set { repaireDate[i] = value; }
        }

        public String ListItem
        {
            get { return "C " + Brand + " " + price; }
        }

        public void Write()
        {
            Console.WriteLine("Марка: " + Brand + "\nМощность: " + Power + "\nЦена: " + Price);
            if (repaireDate.Count != 0)
            {
                Console.WriteLine("\nДаты ремонта:");
                foreach (DateTime item in repaireDate)
                    Console.WriteLine("    " + item.ToString());
            }
        }
    }
}
