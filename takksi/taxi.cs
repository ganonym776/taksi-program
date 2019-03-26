using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace takksi
{
    class taxi
    {
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public string NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("\n\nDriver Name\t\t: {0}", DriverName);

           /* if (OnDuty == true)
            {*/
                Console.WriteLine("Status\t\t\t: {0}", OnDuty ? "Ready" : "Free");
            /*}
            else
            {
                Console.WriteLine("Status\t\t\t: Free");
            }*/

            Console.WriteLine("Number Of Passenger\t: {0}", NumPassenger);

        }
        public void PickUpPassenger()
        {
            Console.WriteLine("\n\n{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
        }
    }
}
