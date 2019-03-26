using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takksi
{
    class Program
    {
        static void Main(string[] args)
        {
            taxi baru = new taxi();

            Console.Write("Masukkan Nama Driver\t: ");
            baru.DriverName = Console.ReadLine();
            Console.Write("Masukkan Status \t: ");
            baru.OnDuty = bool.Parse(Console.ReadLine());
            Console.Write("Masukkan Nomor Passenger: ");
            baru.NumPassenger = Console.ReadLine();

            baru.TaxiInfo();
            baru.PickUpPassenger();
            baru.DropOffPassenger();
            Console.ReadKey();
        }
    }
}
