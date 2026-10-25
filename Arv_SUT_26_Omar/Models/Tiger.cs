using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_SUT_26_Omar.Models
{
    internal class Tiger : Animal
    {
        public double TerritorySize { get; set; } = 0.0;
        public Tiger(string name, string species, int age, bool isPredator, string habitat, double territorySize) : base(name, species, age, isPredator, habitat)
        {
            TerritorySize = territorySize;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }
        public override void Move()
        {
            Console.WriteLine("Runs swiftly on all fours");
        }
        public override void Eat()
        {
            Console.WriteLine("Eats meat");
        }
        public void Hunt()
        {
            Console.WriteLine("The tiger is hunting for prey.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, IsPredator: {IsPredator}, Habitat: {Habitat}, TerritorySize: {TerritorySize}");
        }
        
    }
}
