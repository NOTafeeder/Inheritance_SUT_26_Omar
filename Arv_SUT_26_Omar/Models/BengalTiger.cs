using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_SUT_26_Omar.Models
{
    internal class BengalTiger : Tiger
    {
        public bool LivesInIndia { get; set; } = true;
        public BengalTiger(string name, string species, int age, bool isPredator, string habitat, double territorySize, bool livesInIndia) : base(name, species, age, isPredator, habitat, territorySize)
        {
            LivesInIndia = livesInIndia;
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
        public void Swim()
        {
            Console.WriteLine("The Bengal tiger is swimming.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, IsPredator: {IsPredator}, Habitat: {Habitat}, TerritorySize: {TerritorySize}, LivesInIndia: {LivesInIndia}");
        }
    }
}
