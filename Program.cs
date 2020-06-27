using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._20HW
{
    class Program
    {
      

        public void PrintVehicle()
        {

        }
        static void Main(string[] args)
        {
            Car Mazda = new Car
            {
                _Model = "6",
                _NumberOfDoors = 4,
                _NumberOfWheels = 4
            };

            Car Honda = new Car
            {
                _Model = "Civic",
                _NumberOfDoors = 5,
                _NumberOfWheels = 4
            };

            Motorcycle Sanyung = new Motorcycle
            {
                _NumberOfWheels = 2,
                _Model = "Joymax",
                _NumberOfHandBreaks = 2
            };

            Motorcycle Ducati = new Motorcycle
            {
                _NumberOfHandBreaks = 2,
                _Model = "Monster 797",
                _NumberOfWheels = 2
            };

            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0]= new Car()
            {
                _Model = "Mercedes SLS",
                _NumberOfDoors = 2,
                _NumberOfWheels = 4

            };
          
            vehicles[1]= new Motorcycle()
            {
                _Model = "Yamaha",
                _NumberOfWheels = 2,
                _NumberOfHandBreaks = 2
            };
            vehicles[2] = new Car()
            {
                _Model = "Lamborgini",
                _NumberOfWheels = 4,
                _NumberOfDoors = 2
            };

            Carrier m = new Carrier()
            {
                _vehicles = new Vehicle[2]
                {
                    new Car()
                    {
                        _Model = "Citroen Berlingo",
                        _NumberOfDoors = 5,
                        _NumberOfWheels = 4
                    },
                    new Motorcycle()
                    {
                        _Model = "Harley Davidson",
                        _NumberOfWheels = 2,
                        _NumberOfHandBreaks = 2,
                    }


                }





            };







        }

    }
}
