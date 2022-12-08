using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Reflection;

namespace Homework3_3
{
    abstract class Vehicle
    {
        public double longitude;
        public double latitude;
        public double price;
        public int speed;
        public int productionYear;

        public void Show(Type myType, Object obj)
        {
            Console.WriteLine(myType.Name);
            foreach (FieldInfo field in myType.GetFields())
            {
                Console.WriteLine($"{field.Name} = {field.GetValue(obj)}");
            }
            Console.WriteLine(new string('-',60));
        }

    }

    class Plane : Vehicle
    {
        public int numberOfPassengers;
        public int height;
        public void Show(Plane plane)
        {
            Type myType = typeof(Plane);
            base.Show(myType, (object)plane);
        }

    }
    class Car : Vehicle
    {
        public void Show(Car car)
        {
            Type myType = typeof(Car);
            base.Show(myType, (object)car);
        }
    }
    class Ship : Vehicle
    {
        public int numberOfPassengers;
        public string homePort;

        
        public void Show(Ship ship)
        {
            Type myType = typeof(Ship);
            base.Show(myType, (object)ship);
        }

    }

    

   
}
