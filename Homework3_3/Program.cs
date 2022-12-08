using System;

namespace Homework3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Plane plane = new Plane()
            {
                longitude = 10,
                latitude = 20,
                price = 60000,
                speed = 800,
                productionYear = 2015,
                numberOfPassengers = 40,
                height = 8000
            };

            plane.Show(plane);

            Car car = new Car()
            {
                price = 40000,
                speed = 60,
                productionYear = 2019,

            };
            car.Show(car);

            Ship ship = new Ship()
            {
                numberOfPassengers = 3000,
                homePort = "Singapore",
                longitude = 50.45077,
                latitude = 30.5229,
                price = 800000000,
                speed = 30,
                productionYear = 2018
            };
            ship.Show(ship);


            Console.ReadKey();
        }
    }
}
