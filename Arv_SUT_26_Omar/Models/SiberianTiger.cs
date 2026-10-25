using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_SUT_26_Omar.Models
{
    internal class SiberianTiger : Tiger
    {
        public string FurColor { get; set; } = "White with black stripes";
        public SiberianTiger(string name, string species, int age, bool isPredator, string habitat, double territorySize, string furColor) : base(name, species, age, isPredator, habitat, territorySize)
        {
            FurColor = furColor;
        }
        public override void MakeSound()
        {
            Console.WriteLine("Loud roar!");
        }
        public override void Move()
        {
            Console.WriteLine("Moves stealthily through the snow");
        }
        public override void Eat()
        {
            Console.WriteLine("Eats large prey like deer and wild boar");
        }
        public void SurviveWinter()
        {
            Console.WriteLine("The Siberian tiger is surviving during the cold winter months.");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, IsPredator: {IsPredator}, Habitat: {Habitat}, TerritorySize: {TerritorySize}, FurColor: {FurColor}");
        }
        
    }
}
