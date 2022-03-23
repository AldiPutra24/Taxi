namespace TugasClass
{
class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properti
            taxi.DriveNama = "Aldi";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        
            Console.ReadKey();
        }
    }
}