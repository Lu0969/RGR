using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR3_Mashini
{
    class Program
    {
        static void Main(string[] args)
        {
            Car volvo = new Car("Volvo", 200, 100000);
            List<DateTime> oldNissanRepairDate = new List<DateTime>()
            {
                new DateTime(2001,12,10),
                new DateTime(2002, 1, 1),
                new DateTime(2003, 4, 14),
                new DateTime(2003, 7, 30)
            };
            Car oldNissan = new Car("Nissan", 120, 50000, oldNissanRepairDate);

            volvo.Write();
            Console.WriteLine();
            oldNissan.Write();

            Console.ReadKey();
        }
    }
}
