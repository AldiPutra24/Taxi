using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TugasClass
{
    public class Taxi
    {
        //properti
        public string DriveNama { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("\nDriveNama    : {0}", DriveNama);
            Console.WriteLine("OnDuty       : {0}", OnDuty);
            Console.WriteLine("NumPassengerk: {0}", NumPassenger);
        }        

        public void PickUpPassenger()
        {
            Console.WriteLine("\n Aldi Sedang menjemput penumpang!\n");
        }

        public void DropOffPassenger()
        {
            Console.WriteLine(" Aldi selesai mengantar penumpang!\n");
        }
    }
}