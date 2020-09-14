using System;
using System.Collections.Generic;

namespace name.heby
{
    public class SortTest
    {
        public static void ListCars(){
            var cars = new List<Car>()
            {
                {new Car(){Name = "car1", Color = "blue", Speed = 20}},
                {new Car(){Name = "car2", Color = "red", Speed = 50}},
                {new Car(){Name = "car3", Color = "green", Speed = 10}},
                {new Car(){Name = "car4", Color = "blue", Speed = 50}},
                {new Car(){Name = "car5", Color = "blue", Speed = 30}},
                {new Car(){Name = "car6", Color = "red", Speed = 60}},
                {new Car(){Name = "car7", Color = "green", Speed = 50}},
            };
            
            cars.Sort();
            foreach (var car in cars)
            {
                Console.WriteLine($"Name : {car.Name} , Color : {car.Color}, Speed : {car.Speed}");
            }
        }
    }
    
    
    public class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }

        public int CompareTo(Car other)
        {
            int compare = String.Compare(this.Color, other.Color, true);
            compare = -compare;
            return compare;
        }
    }
}