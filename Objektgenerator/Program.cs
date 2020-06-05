using System;
using System.Collections.Generic;

namespace Objektgenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Objektgenerator objektgenerator = new Objektgenerator();

            Car newCar = objektgenerator.GetNewObject<Car>();

            newCar.Brand = "BMW";

            List<Car> cars = objektgenerator.GetNewObjects<Car>(4);

            Animal animal = objektgenerator.GetNewObjectWithPara<Animal>("Monkey", "charls");

            List<Animal> animals = objektgenerator.GetNewObjectsWithPara<Animal>(10,"Monkey", "charls");


        }
    }
}
