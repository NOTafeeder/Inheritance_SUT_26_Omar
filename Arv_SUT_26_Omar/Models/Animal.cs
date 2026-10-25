using System;
using System.Collections.Generic;
using System.Text;

namespace Arv_SUT_26_Omar.Models
{
    internal abstract class Animal
    {
        protected Animal(string name, string species, int age, bool isPredator, string habitat)
        {
            Name = name;
            Species = species;
            Age = age;
            IsPredator = isPredator;
            Habitat = habitat;
        }
        public string Name { get; set; } = "Unknown";
        public string Species { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public bool IsPredator { get; set; } = false;
        public string Habitat { get; set; } = "Unknown";
        public abstract void MakeSound();
        public abstract void Move();
        public abstract void Eat();
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Species: {Species}, Age: {Age}, IsPredator: {IsPredator}, Habitat: {Habitat}");
        }
    }
}
